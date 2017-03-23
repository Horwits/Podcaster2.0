using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;

using Podcaster.Models.Contracts;

namespace Podcaster.Data.Repositories.Contracts
{
    public interface IRoleRepository
    {
        void Add(IUserRole userRole);

        Task<IRole<Guid>> FindByNameAsync(string name);

        Task<List<string>> GetRolesNameByUserId(Guid userId);

        Task<bool> IsInRoleAsync(Guid userId, Guid roleId);

        void Remove(Func<IUserRole, bool> func);
    }
}