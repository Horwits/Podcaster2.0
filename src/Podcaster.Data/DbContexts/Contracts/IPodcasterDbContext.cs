using System.Data.Entity;

using Podcaster.Models;
using Podcaster.Models.Contracts;

namespace Podcaster.Data.DbContexts.Contracts
{
    public interface IPodcasterDbContext
    {
        IDbSet<Episode> Episodes { get; set; }

        IDbSet<Podcast> Podcasts { get; set; }
    }
}