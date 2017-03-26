using System;

using Bytes2you.Validation;

using Podcaster.Data.DataEF.Contracts;
using Podcaster.Models;
using Podcaster.Services.User.Contracts;

namespace Podcaster.Services.User
{
    public class UserService : IUserService
    {
        private readonly IPodcasterDataEF data;

        public UserService(IPodcasterDataEF data)
        {
            Guard.WhenArgument(data, nameof(data)).IsNull().Throw();

            this.data = data;
        }

        public void Add(ApplicationUser user)
        {
            Guard.WhenArgument(user, nameof(user)).IsNull().Throw();

            this.data.Users.Add(user);
        }

        public void Delete(ApplicationUser user)
        {
            Guard.WhenArgument(user, nameof(user)).IsNull().Throw();

            this.data.Users.Add(user);
        }

        public ApplicationUser FindById(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException(nameof(id));
            }

            return this.data.Users.GetById(id);
        }

        public void Update(ApplicationUser user)
        {
            Guard.WhenArgument(user, nameof(user)).IsNull().Throw();

            this.data.Users.Add(user);
        }
    }
}