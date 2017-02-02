using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication5478.Startup))]
namespace WebApplication5478
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
