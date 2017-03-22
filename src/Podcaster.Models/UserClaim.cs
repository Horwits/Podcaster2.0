using System;

using Podcaster.Models.Contracts;

namespace Podcaster.Models
{
    public class UserClaim : IUserClaim
    {
        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        public Guid Id { get; set; }

        public IUser User { get; set; }

        public Guid UserId { get; set; }
    }
}