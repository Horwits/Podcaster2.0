using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Podcaster.Models.Contracts;

namespace Podcaster.Data.Repositories.Contracts
{
    public interface IUserLoginsRepository
    {
        void Add(IUserLogin userLogin);

        Task<IUserLogin> FindByLoginProviderAndProviderKey(string loginLoginProvider, string loginProviderKey);

        Task<IEnumerable<IUserLogin>> GetByUserId(Guid userId);

        void Remove(Func<IUserLogin, bool> func);
    }
}