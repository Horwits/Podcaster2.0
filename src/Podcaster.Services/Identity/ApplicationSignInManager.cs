using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

using Podcaster.Models;

namespace Podcaster.Services.Identity
{
    [ExcludeFromCodeCoverage]
    public class ApplicationSignInManager : SignInManager<User, Guid>
    {
        public ApplicationSignInManager(
            ApplicationUserManager userManager,
            IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(User user)
        {
            return CreateUserIdentityAsync((ApplicationUserManager)this.UserManager, user);
        }

        private static async Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUserManager manager, User user)
        {
            var userIdentity = await manager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}