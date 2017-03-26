using System.Diagnostics.CodeAnalysis;

using Microsoft.Owin;

using Owin;

[assembly: OwinStartup(typeof(Podcaster.Web.Startup))]

namespace Podcaster.Web
{
    [ExcludeFromCodeCoverage]

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}