using System.Threading.Tasks;

using Podcaster.Data.DbContexts.Contracts;
using Podcaster.Data.Repositories.Contracts;

namespace Podcaster.Data.PodcasterData
{
    public interface IPodcasterDataEf
    {
        IPodcasterDbContext Context { get; }

        IRoleRepository Roles { get; set; }

        IUserClaimsRepository UserClaims { get; set; }

        IUserLoginsRepository UserLogins { get; set; }

        IUsersRepository Users { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}