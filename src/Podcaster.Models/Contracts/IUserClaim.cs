using System;

namespace Podcaster.Models.Contracts
{
    public interface IUserClaim
    {
        string ClaimType { get; set; }

        string ClaimValue { get; set; }

        Guid Id { get; set; }

        IUser User { get; set; }

        Guid UserId { get; set; }
    }
}