using Microsoft.AspNet.Identity.EntityFramework;

using Podcaster.Models;

namespace Podcaster.Data.DbContexts
{
    public class PodcasterDbContext : IdentityDbContext<ApplicationUser>
    {
        public PodcasterDbContext()
            : base("PodcasterDataBase", throwIfV1Schema: false)
        {
        }

        public static PodcasterDbContext Create()
        {
            return new PodcasterDbContext();
        }
    }
}