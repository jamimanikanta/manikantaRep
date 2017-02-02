using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Githubtrailproject.Startup))]
namespace Githubtrailproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
