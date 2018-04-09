using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using QuanLyCuTru.Models;

namespace QuanLyCuTru
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }
    }

    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }

    public class MyPasswordValidator : PasswordValidator
    {
        public override Task<IdentityResult> ValidateAsync(string item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(item) || item.Length < RequiredLength)
            {
                //TODO: add error message from your own resources file with specified culture.
                //TODO: remove following line if your code completed
                //errors.Add(String.Format(CultureInfo.CurrentCulture, Resources.PasswordTooShort, RequiredLength));
            }
            if (RequireNonLetterOrDigit && item.All(IsLetterOrDigit))
            {
                //TODO: add error message from your own resources file with specified culture.
                //TODO: remove following line if your code completed
                //errors.Add(Resources.PasswordRequireNonLetterOrDigit);
            }
            if (RequireDigit && item.All(c => !IsDigit(c)))
            {
                //TODO: add error message from your own resources file with specified culture.
                //TODO: remove following line if your code completed
                errors.Add("Mật khẩu phải có ký tự số");
            }
            if (RequireLowercase && item.All(c => !IsLower(c)))
            {
                //TODO: add error message from your own resources file with specified culture.
                //TODO: remove following line if your code completed
                //errors.Add(Resources.PasswordRequireLower);
            }
            if (RequireUppercase && item.All(c => !IsUpper(c)))
            {
                //TODO: add error message from your own resources file with specified culture.
                //TODO: remove following line if your code completed
                //errors.Add(Resources.PasswordRequireUpper);
            }
            if (errors.Count == 0)
            {
                //TODO: add error message from your own resources file with specified culture.
                //TODO: remove following line if your code completed
                //return Task.FromResult(IdentityResult.Success);
            }
            return Task.FromResult(IdentityResult.Failed(String.Join(" ", errors)));
        }
    }

    // Configure the application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
            : base(store)
        {
        }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context) 
        {
            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(context.Get<ApplicationDbContext>()));
            // Configure validation logic for usernames
            manager.UserValidator = new UserValidator<ApplicationUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            // Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = false,
                RequireDigit = true,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            // Configure user lockout defaults
            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;

            // Register two factor authentication providers. This application uses Phone and Emails as a step of receiving a code for verifying the user
            // You can write your own provider and plug it in here.
            manager.RegisterTwoFactorProvider("Phone Code", new PhoneNumberTokenProvider<ApplicationUser>
            {
                MessageFormat = "Your security code is {0}"
            });
            manager.RegisterTwoFactorProvider("Email Code", new EmailTokenProvider<ApplicationUser>
            {
                Subject = "Security Code",
                BodyFormat = "Your security code is {0}"
            });
            manager.EmailService = new EmailService();
            manager.SmsService = new SmsService();
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = 
                    new DataProtectorTokenProvider<ApplicationUser>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }
    }

    // Configure the application sign-in manager which is used in this application.
    public class ApplicationSignInManager : SignInManager<ApplicationUser, string>
    {
        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUser user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }
    }
}
