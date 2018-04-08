using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyCuTru.Startup))]
namespace QuanLyCuTru
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
