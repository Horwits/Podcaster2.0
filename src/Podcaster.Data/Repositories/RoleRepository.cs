using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;

using Podcaster.Data.DbContexts.Contracts;
using Podcaster.Data.Repositories.Base;
using Podcaster.Data.Repositories.Contracts;
using Podcaster.Models.Contracts;

namespace Podcaster.Data.Repositories
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(IPodcasterDbContext context)
            : base(context)
        {
        }

        public void Add(IUserRole userRole)
        {
            this.Context.UserRoles.Add(userRole);
        }

        public Task<IRole<Guid>> FindByNameAsync(string name)
        {
            return this.Context.Roles.FirstOrDefaultAsync(u => u.Name.ToUpper() == name.ToUpper());
        }

        public async Task<List<string>> GetRolesNameByUserId(Guid userId)
        {
            var userRoles = this.Context.UserRoles;
            var roles = this.Context.Roles;
            return
                await (from r in roles
                       join ur in userRoles on r.Id equals ur.RoleId
                       where ur.UserId == userId
                       select r.Name).ToListAsync();
        }

        public async Task<bool> IsInRoleAsync(Guid userId, Guid roleId)
        {
            return await this.Context.UserRoles.AnyAsync(ur => ur.UserId == userId && ur.RoleId == roleId);
        }

        public void Remove(Func<IUserRole, bool> func)
        {
            this.Context.UserRoles.Remove(x => x.userRole);
        }
    }
}