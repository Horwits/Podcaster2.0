using Microsoft.Owin;

using Owin;

using Podcaster.Services;

[assembly: OwinStartup(typeof(Podcaster.Web.Startup))]

namespace Podcaster.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}