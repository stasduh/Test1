using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebVersionHeartRate.Startup))]
namespace WebVersionHeartRate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
