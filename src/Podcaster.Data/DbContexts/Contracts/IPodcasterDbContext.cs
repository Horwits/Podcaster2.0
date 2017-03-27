using System.Data.Entity;

using Podcaster.Models;

namespace Podcaster.Data.DbContexts.Contracts
{
    public interface IPodcasterDbContext
    {
        IDbSet<PodcastEntity> Podcasts { get; set; }
    }
}