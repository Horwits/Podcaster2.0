using System;
using System.Threading.Tasks;

using Podcaster.Models;
using Podcaster.Models.Contracts;

namespace Podcaster.Data.Repositories.Contracts
{
    public interface IUsersRepository
    {
        void Add(IUser user);

        void Delete(IUser entity);

        Task<User> FindByEmailAsync(string email);

        Task<User> FindByNameAsync(string name);

        IUser GetById(Guid id);

        Task<User> GetByIdAsync(Guid userId);

        IUser GetByUsername(string username);

        void Remove(IUser user);

        void Update(IUser user);
    }
}