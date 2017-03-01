using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Drummers.Mvc.Startup))]
namespace Drummers.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
