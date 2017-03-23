using System.Web;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

using Ninject.Modules;
using Ninject.Web.Common;

using Podcaster.Identity;
using Podcaster.Models;
using Podcaster.Models.Contracts;

namespace Podcaster.CompositionModules.Auth
{
    public class AuthModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAuthenticationManager>().ToMethod(c => HttpContext.Current.GetOwinContext().Authentication);

            this.Bind<IApplicationUserManager>().To<ApplicationUserManager>().InRequestScope();

            this.Bind<IApplicationSignInManager>().To<ApplicationSignInManager>().InRequestScope();

            this.Bind<IUserStore<ApplicationUser>>().To<UserStore<ApplicationUser>>().InRequestScope();
        }
    }
}
