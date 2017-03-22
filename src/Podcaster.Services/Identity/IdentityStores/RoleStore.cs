using System;
using System.Threading.Tasks;

using Podcaster.Models;
using Podcaster.Services.Identity.Contracts;

namespace Podcaster.Services.Identity.IdentityStores
{
    public class RoleStore : IRoleStore
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Role role)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Role role)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<Role> FindByIdAsync(Guid roleId)
        {
            throw new NotImplementedException();
        }

        public Task<Role> FindByNameAsync(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}