using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mis4200_sd2.Startup))]
namespace mis4200_sd2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
