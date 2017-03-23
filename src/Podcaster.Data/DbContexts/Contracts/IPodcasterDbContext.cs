using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Podcaster.Data.DbContexts.Contracts
{
    public interface IPodcasterDbContext : IDisposable
    {
        DbContext DbContext { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}