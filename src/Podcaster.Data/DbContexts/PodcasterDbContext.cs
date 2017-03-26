using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNet.Identity.EntityFramework;

using Podcaster.Data.DbContexts.Contracts;
using Podcaster.Models;
using Podcaster.Models.Contracts;

namespace Podcaster.Data.DbContexts
{
    [ExcludeFromCodeCoverage]
    public class PodcasterDbContext : IdentityDbContext<ApplicationUser>, IPodcasterDbContext
    {
        public PodcasterDbContext()
            : base("PodcasterDataBase", throwIfV1Schema: false)
        {
        }

        public IDbSet<PodcastEntity> Podcasts { get; set; }

        public static PodcasterDbContext Create()
        {
            return new PodcasterDbContext();
        }
    }
}