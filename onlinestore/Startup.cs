using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onlinestore.Startup))]
namespace onlinestore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
