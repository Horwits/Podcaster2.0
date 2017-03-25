using System.Data.Entity.Migrations;
using System.Linq;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

using Podcaster.Data.DbContexts;
using Podcaster.Models;

namespace Podcaster.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PodcasterDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PodcasterDbContext context)
        {
            if (!context.Roles.Any(role => role.Name == "User"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("User");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Administrator"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Administrator");
                manager.Create(role);
            }
        }
    }
}