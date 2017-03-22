using System;

using Microsoft.AspNet.Identity;

using Podcaster.Models.Contracts;

using IUser = Podcaster.Models.Contracts.IUser;

namespace Podcaster.Models
{
    public class UserRole : IUserRole
    {
        public IRole<Guid> Role { get; set; }

        public Guid RoleId { get; set; }

        public IUser User { get; set; }

        public Guid UserId { get; set; }
    }
}