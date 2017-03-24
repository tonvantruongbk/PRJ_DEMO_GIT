using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRJ_DEMO_GIT.Startup))]
namespace PRJ_DEMO_GIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
