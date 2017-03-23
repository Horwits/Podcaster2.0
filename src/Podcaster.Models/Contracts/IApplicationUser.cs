using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Podcaster.Models.Contracts
{
    public interface IApplicationUser : IUser<string>
    {
        int AccessFailedCount { get; set; }

        ICollection<IdentityUserClaim> Claims { get; }

        string Email { get; set; }

        bool EmailConfirmed { get; set; }

        bool LockoutEnabled { get; set; }

        DateTime? LockoutEndDateUtc { get; set; }

        ICollection<IdentityUserLogin> Logins { get; }

        string PasswordHash { get; set; }

        string PhoneNumber { get; set; }

        bool PhoneNumberConfirmed { get; set; }

        ICollection<IdentityUserRole> Roles { get; }

        string SecurityStamp { get; set; }

        bool TwoFactorEnabled { get; set; }

        ClaimsIdentity GenerateUserIdentity(IApplicationUserManager manager);

        Task<ClaimsIdentity> GenerateUserIdentityAsync(IApplicationUserManager manager);
    }
}