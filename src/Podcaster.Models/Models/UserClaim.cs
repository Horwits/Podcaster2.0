using System;

namespace Podcaster.Models.Models
{
    public class UserClaim
    {
        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        public Guid Id { get; set; }

        public User User { get; set; }

        public Guid UserId { get; set; }
    }
}