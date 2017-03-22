using System;

namespace Podcaster.Models.Contracts
{
    public interface IUser
    {
        int AccessFailedCount { get; set; }

        DateTime CreateDate { get; set; }

        string Email { get; set; }

        bool EmailConfirmed { get; set; }

        Guid Id { get; set; }

        bool LockoutEnabled { get; set; }

        DateTime? LockoutEndDateUtc { get; set; }

        string PasswordHash { get; set; }

        string PhoneNumber { get; set; }

        bool PhoneNumberConfirmed { get; set; }

        string SecurityStamp { get; set; }

        bool TwoFactorEnabled { get; set; }

        string UserName { get; set; }
    }
}