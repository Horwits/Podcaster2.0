using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Podcaster.WebClient.Startup))]
namespace Podcaster.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
