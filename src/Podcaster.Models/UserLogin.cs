using System;

using Podcaster.Models.Contracts;

namespace Podcaster.Models
{
    public class UserLogin : IUserLogin
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        public IUser User { get; set; }

        public Guid UserId { get; set; }
    }
}