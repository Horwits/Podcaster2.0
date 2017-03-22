using System;

namespace Podcaster.Models.Models
{
    public class UserLogin
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        public User User { get; set; }

        public Guid UserId { get; set; }
    }
}