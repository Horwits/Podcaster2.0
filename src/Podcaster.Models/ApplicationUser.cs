using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

using Podcaster.Models.Contracts;

namespace Podcaster.Models
{
    public class ApplicationUser : IdentityUser, IApplicationUser
    {
        public ApplicationUser(string userName, string email)
            : base(userName)
        {
        }

        public ApplicationUser()
        {
        }

        public virtual ClaimsIdentity GenerateUserIdentity(IApplicationUserManager manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }

        public virtual Task<ClaimsIdentity> GenerateUserIdentityAsync(IApplicationUserManager manager)
        {
            return Task.FromResult(this.GenerateUserIdentity(manager));
        }
    }
}