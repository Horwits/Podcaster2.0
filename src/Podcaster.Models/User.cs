using System;

using Microsoft.AspNet.Identity;

using IUser = Podcaster.Models.Contracts.IUser;

namespace Podcaster.Models
{
    public class User : IUser<Guid>, IUser
    {
        public User()
        {
            this.CreateDate = DateTime.Now;
        }

        public virtual int AccessFailedCount { get; set; }

        public DateTime CreateDate { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public Guid Id { get; set; }

        public virtual bool LockoutEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public string SecurityStamp { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public string UserName { get; set; }
    }
}