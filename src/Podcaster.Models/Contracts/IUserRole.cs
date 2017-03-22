using System;

using Microsoft.AspNet.Identity;

namespace Podcaster.Models.Contracts
{
    public interface IUserRole
    {
        IRole<Guid> Role { get; set; }

        Guid RoleId { get; set; }

        IUser User { get; set; }

        Guid UserId { get; set; }
    }
}