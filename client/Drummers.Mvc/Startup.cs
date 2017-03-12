using Drummers.Data.Factories.Contracts;
using Drummers.Mvc.App_Start;

using Microsoft.Owin;

using Ninject;

using Owin;

[assembly: OwinStartupAttribute(typeof(Drummers.Mvc.Startup))]

namespace Drummers.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var kernel = NinjectWebCommon.Kernel;
            this.ConfigureAuth(app, kernel.Get<IDrummersDbContextFactory>());
        }
    }
}
