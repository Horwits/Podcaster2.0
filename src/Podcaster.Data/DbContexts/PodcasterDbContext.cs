using System.Data.Entity;

using Microsoft.AspNet.Identity.EntityFramework;

using Podcaster.Data.DbContexts.Contracts;
using Podcaster.Models;

namespace Podcaster.Data.DbContexts
{
    public class PodcasterDbContext : IdentityDbContext<ApplicationUser>, IPodcasterDbContext
    {
        public PodcasterDbContext()
            : base("DefaultConnection")
        {
            this.Database.CreateIfNotExists();
        }

        public DbContext DbContext { get; }
    }
}