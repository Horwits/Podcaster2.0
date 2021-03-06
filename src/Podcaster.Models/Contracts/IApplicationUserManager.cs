using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;

namespace Podcaster.Models.Contracts
{
    public interface IApplicationUserManager : IDisposable
    {
        IClaimsIdentityFactory<ApplicationUser, string> ClaimsIdentityFactory { get; set; }

        TimeSpan DefaultAccountLockoutTimeSpan { get; set; }

        IIdentityMessageService EmailService { get; set; }

        int MaxFailedAccessAttemptsBeforeLockout { get; set; }

        IPasswordHasher PasswordHasher { get; set; }

        IIdentityValidator<string> PasswordValidator { get; set; }

        IIdentityMessageService SmsService { get; set; }

        bool SupportsQueryableUsers { get; }

        bool SupportsUserClaim { get; }

        bool SupportsUserEmail { get; }

        bool SupportsUserLockout { get; }

        bool SupportsUserLogin { get; }

        bool SupportsUserPassword { get; }

        bool SupportsUserPhoneNumber { get; }

        bool SupportsUserRole { get; }

        bool SupportsUserSecurityStamp { get; }

        bool SupportsUserTwoFactor { get; }

        IDictionary<string, IUserTokenProvider<ApplicationUser, string>> TwoFactorProviders { get; }

        bool UserLockoutEnabledByDefault { get; set; }

        IQueryable<ApplicationUser> Users { get; }

        IUserTokenProvider<ApplicationUser, string> UserTokenProvider { get; set; }

        IIdentityValidator<ApplicationUser> UserValidator { get; set; }

        Task<IdentityResult> AccessFailedAsync(string userId);

        Task<IdentityResult> AddClaimAsync(string userId, Claim claim);

        Task<IdentityResult> AddLoginAsync(string userId, UserLoginInfo login);

        IdentityResult AddPassword(string userId, string password);

        Task<IdentityResult> AddPasswordAsync(string userId, string password);

        Task<IdentityResult> AddToRoleAsync(string userId, string role);

        Task<IdentityResult> AddToRolesAsync(string userId, params string[] roles);

        IdentityResult ChangePassword(string userId, string currentPassword, string newPassword);

        Task<IdentityResult> ChangePasswordAsync(string userId, string currentPassword, string newPassword);

        Task<IdentityResult> ChangePhoneNumberAsync(string userId, string phoneNumber, string token);

        Task<bool> CheckPasswordAsync(ApplicationUser user, string password);

        IdentityResult ConfirmEmail(string userId, string token);

        Task<IdentityResult> ConfirmEmailAsync(string userId, string token);

        IdentityResult Create(ApplicationUser user, string password);

        Task<IdentityResult> CreateAsync(ApplicationUser user);

        Task<IdentityResult> CreateAsync(ApplicationUser user, string password);

        ClaimsIdentity CreateIdentity(ApplicationUser user, string authenticationType);

        Task<ClaimsIdentity> CreateIdentityAsync(ApplicationUser user, string authenticationType);

        Task<IdentityResult> DeleteAsync(ApplicationUser user);

        Task<ApplicationUser> FindAsync(string userName, string password);

        Task<ApplicationUser> FindAsync(UserLoginInfo login);

        Task<ApplicationUser> FindByEmailAsync(string email);

        ApplicationUser FindById(string userId);

        Task<ApplicationUser> FindByIdAsync(string userId);

        ApplicationUser FindByName(string email);

        Task<ApplicationUser> FindByNameAsync(string userName);

        Task<string> GenerateChangePhoneNumberTokenAsync(string userId, string phoneNumber);

        Task<string> GenerateEmailConfirmationTokenAsync(string userId);

        Task<string> GeneratePasswordResetTokenAsync(string userId);

        Task<string> GenerateTwoFactorTokenAsync(string userId, string twoFactorProvider);

        Task<string> GenerateUserTokenAsync(string purpose, string userId);

        Task<int> GetAccessFailedCountAsync(string userId);

        Task<IList<Claim>> GetClaimsAsync(string userId);

        Task<string> GetEmailAsync(string userId);

        Task<bool> GetLockoutEnabledAsync(string userId);

        Task<DateTimeOffset> GetLockoutEndDateAsync(string userId);

        Task<IList<UserLoginInfo>> GetLoginsAsync(string userId);

        Task<string> GetPhoneNumberAsync(string userId);

        Task<IList<string>> GetRolesAsync(string userId);

        Task<string> GetSecurityStampAsync(string userId);

        Task<bool> GetTwoFactorEnabledAsync(string userId);

        Task<IList<string>> GetValidTwoFactorProvidersAsync(string userId);

        bool HasPassword(string userId);

        Task<bool> HasPasswordAsync(string userId);

        bool IsEmailConfirmed(string userId);

        Task<bool> IsEmailConfirmedAsync(string userId);

        Task<bool> IsInRoleAsync(string userId, string role);

        Task<bool> IsLockedOutAsync(string userId);

        Task<bool> IsPhoneNumberConfirmedAsync(string userId);

        Task<IdentityResult> NotifyTwoFactorTokenAsync(string userId, string twoFactorProvider, string token);

        void RegisterTwoFactorProvider(string twoFactorProvider, IUserTokenProvider<ApplicationUser, string> provider);

        Task<IdentityResult> RemoveClaimAsync(string userId, Claim claim);

        Task<IdentityResult> RemoveFromRoleAsync(string userId, string role);

        Task<IdentityResult> RemoveFromRolesAsync(string userId, params string[] roles);

        Task<IdentityResult> RemoveLoginAsync(string userId, UserLoginInfo login);

        Task<IdentityResult> RemovePasswordAsync(string userId);

        Task<IdentityResult> ResetAccessFailedCountAsync(string userId);

        Task<IdentityResult> ResetPasswordAsync(string userId, string token, string newPassword);

        Task SendEmailAsync(string userId, string subject, string body);

        Task SendSmsAsync(string userId, string message);

        Task<IdentityResult> SetEmailAsync(string userId, string email);

        Task<IdentityResult> SetLockoutEnabledAsync(string userId, bool enabled);

        Task<IdentityResult> SetLockoutEndDateAsync(string userId, DateTimeOffset lockoutEnd);

        Task<IdentityResult> SetPhoneNumberAsync(string userId, string phoneNumber);

        Task<IdentityResult> SetTwoFactorEnabledAsync(string userId, bool enabled);

        Task<IdentityResult> UpdateAsync(ApplicationUser user);

        Task<IdentityResult> UpdateSecurityStampAsync(string userId);

        Task<bool> VerifyChangePhoneNumberTokenAsync(string userId, string token, string phoneNumber);

        Task<bool> VerifyTwoFactorTokenAsync(string userId, string twoFactorProvider, string token);

        Task<bool> VerifyUserTokenAsync(string userId, string purpose, string token);
    }
}