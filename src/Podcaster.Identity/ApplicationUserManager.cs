using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;

using Podcaster.Models;
using Podcaster.Models.Contracts;

namespace Podcaster.Identity
{
    public class ApplicationUserManager : UserManager<ApplicationUser>, IApplicationUserManager
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
            : base(store)
        {
        }

        public virtual IdentityResult AddPassword(string userId, string password)
        {
            return UserManagerExtensions.AddPassword(this, userId, password);
        }

        public virtual IdentityResult ChangePassword(string userId, string currentPassword, string newPassword)
        {
            return UserManagerExtensions.ChangePassword(this, userId, currentPassword, newPassword);
        }

        public virtual IdentityResult ConfirmEmail(string userId, string token)
        {
            return UserManagerExtensions.ConfirmEmail(this, userId, token);
        }

        public virtual IdentityResult Create(ApplicationUser user, string password)
        {
            return UserManagerExtensions.Create(this, user, password);
        }

        public virtual ClaimsIdentity CreateIdentity(ApplicationUser user, string authenticationType)
        {
            return UserManagerExtensions.CreateIdentity(this, user, authenticationType);
        }

        public virtual ApplicationUser FindById(string userId)
        {
            return UserManagerExtensions.FindById(this, userId);
        }

        public virtual ApplicationUser FindByName(string email)
        {
            return UserManagerExtensions.FindByName(this, email);
        }

        public virtual bool HasPassword(string userId)
        {
            return UserManagerExtensions.HasPassword(this, userId);
        }

        public virtual bool IsEmailConfirmed(string userId)
        {
            return UserManagerExtensions.IsEmailConfirmed(this, userId);
        }
    }
}