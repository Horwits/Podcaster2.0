using System;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Podcaster.Models.Contracts
{
    public interface IApplicationSignInManager : IDisposable
    {
        IAuthenticationManager AuthenticationManager { get; set; }

        string AuthenticationType { get; set; }

        UserManager<ApplicationUser, string> UserManager { get; set; }

        string ConvertIdFromString(string id);

        string ConvertIdToString(string id);

        Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUser user);

        Task<SignInStatus> ExternalSignInAsync(ExternalLoginInfo loginInfo, bool isPersistent);

        Task<string> GetVerifiedUserIdAsync();

        Task<bool> HasBeenVerifiedAsync();

        SignInStatus PasswordSignIn(string email, string password, bool isPersistent);

        Task<SignInStatus> PasswordSignInAsync(string userName, string password, bool isPersistent, bool shouldLockout);

        Task<bool> SendTwoFactorCodeAsync(string provider);

        void SignIn(ApplicationUser user, bool isPersistent, bool rememberBrowser);

        Task SignInAsync(ApplicationUser user, bool isPersistent, bool rememberBrowser);

        Task<SignInStatus> TwoFactorSignInAsync(string provider, string code, bool isPersistent, bool rememberBrowser);
    }
}