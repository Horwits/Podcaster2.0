using System.Data.Entity;

using Podcaster.Data.Repositories.Contracts;
using Podcaster.Models;

namespace Podcaster.Data.DataEF.Contracts
{
    public interface IPodcasterDataEF
    {
        DbContext Context { get; }

        IRepository<Podcast> Podcasts { get; }

        IRepository<Episode> Episodes { get; }

        IRepository<ApplicationUser> Users { get; }

        void Dispose();

        int SaveChanges();
    }
}
