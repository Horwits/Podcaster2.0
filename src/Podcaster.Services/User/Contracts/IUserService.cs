using System;

using Podcaster.Models;

namespace Podcaster.Services.User.Contracts
{
    public interface IUserService
    {
        void Add(ApplicationUser user);

        void Delete(ApplicationUser user);

        ApplicationUser FindById(Guid? id);

        void Update(ApplicationUser user);
    }
}