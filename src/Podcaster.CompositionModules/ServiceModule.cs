using System.Web;

using Microsoft.Owin.Security;

using Ninject.Modules;
using Ninject.Web.Common;

using Podcaster.Services.Identity;
using Podcaster.Services.Identity.Contracts;
using Podcaster.Services.Identity.IdentityStores;

namespace Podcaster.CompositionModules
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUserStore>().To<UserStore>().InRequestScope();
            this.Bind<IRoleStore>().To<RoleStore>().InRequestScope();

            this.Bind<IAuthenticationManager>().ToMethod(c => HttpContext.Current.GetOwinContext().Authentication);

            this.Bind<ApplicationUserManager>().ToSelf().InRequestScope();

            this.Bind<ApplicationRoleManager>().ToSelf().InRequestScope();
            this.Bind<ApplicationSignInManager>().ToSelf().InRequestScope();
        }
    }
}