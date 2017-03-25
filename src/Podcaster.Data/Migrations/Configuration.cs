using System.Data.Entity.Migrations;
using System.Linq;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

using Podcaster.Common.Constants;
using Podcaster.Data.DbContexts;
using Podcaster.Models;

namespace Podcaster.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<PodcasterDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PodcasterDbContext context)
        {
            SeedRoles(context);

            if (!context.Users.Any())
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
            }
        }

        private static void SeedRoles(PodcasterDbContext context)
        { 
            if (!context.Roles.Any(role => role.Name == GlobalConstants.UserRole))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole(GlobalConstants.UserRole);
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == GlobalConstants.AdminRole))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole(GlobalConstants.AdminRole);
                manager.Create(role);
            }
        }
    }
}