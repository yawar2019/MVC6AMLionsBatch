using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bundleMinified.Startup))]
namespace bundleMinified
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
