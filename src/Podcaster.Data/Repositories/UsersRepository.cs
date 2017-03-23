using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using Podcaster.Data.DbContexts.Contracts;
using Podcaster.Data.Repositories.Base;
using Podcaster.Data.Repositories.Contracts;
using Podcaster.Models.Contracts;

namespace Podcaster.Data.Repositories
{
    public class UsersRepository : BaseRepository, IUsersRepository
    {
        public UsersRepository(IPodcasterDbContext context)
            : base(context)
        {
        }

        public void Delete(IUser entity)
        {
            this.Context.Users.Remove(entity);
        }

        public async Task<IUser> FindByEmailAsync(string email)
        {
            return await this.Context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<IUser> FindByNameAsync(string name)
        {
            return await this.Context.Users.FirstOrDefaultAsync(x => x.UserName == name);
        }

        public IUser GetById(Guid id)
        {
            return this.Context.Users.FirstOrDefault(x => x.Id == id);
        }

        public IUser GetByUsername(string username)
        {
            return this.Context.Users.FirstOrDefault(x => x.UserName == username);
        }
    }
}