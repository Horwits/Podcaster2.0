using System;

namespace Podcaster.Models.Contracts
{
    public interface IUserLogin
    {
        string LoginProvider { get; set; }

        string ProviderKey { get; set; }

        IUser User { get; set; }

        Guid UserId { get; set; }
    }
}