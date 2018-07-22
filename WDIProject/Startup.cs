using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WDIProject.Startup))]
namespace WDIProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
