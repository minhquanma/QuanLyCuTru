﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace QuanLyCuTru.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<CuTru> CuTrus { get; set; }
        public DbSet<LoaiCuTru> LoaiCuTrus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /** Database Relationship 
             *  One-To-Many configurations is not required, it's been mapped automatically
             * **/

            // The junction table between "CuTru has many CongDan" is declared here.
            modelBuilder.Entity<CuTru>()
                .HasMany<NguoiDung>(s => s.CongDans)
                .WithMany(c => c.CuTrus)
                .Map(cs =>
                {
                    cs.MapLeftKey("CuTruId"); // Name of First Table Key
                    cs.MapRightKey("CongDanId"); // Name of Second Table Key
                    cs.ToTable("DangKyCuTru"); // Name of the junction table
                });
        }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}