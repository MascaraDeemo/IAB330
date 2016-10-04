using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(InTouch2CGService.Startup))]

namespace InTouch2CGService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}