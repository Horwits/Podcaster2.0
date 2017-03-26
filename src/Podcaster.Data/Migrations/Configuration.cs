using System.Data.Entity.Migrations;
using System.Linq;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

using Ploeh.AutoFixture;

using Podcaster.Common.Constants;
using Podcaster.Data.DbContexts;
using Podcaster.Models;

namespace Podcaster.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<PodcasterDbContext>
    {
        private UserManager<ApplicationUser> userManager;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PodcasterDbContext context)
        {
            this.userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            this.SeedRoles(context);
            this.SeedUsers(context);

           
        }

        private void SeedRoles(PodcasterDbContext context)
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

        private void SeedUsers(PodcasterDbContext context)
        {
            if (!context.Users.Any())
            {
                var fixture = new Fixture();
                for (int i = 0; i < 10; i++)
                {
                    var mail = $"a{i}b{i * 2}@abv.com";
                    var user = new ApplicationUser { Email = mail, UserName = mail };

                    this.userManager.Create(user, "123456");

                    this.userManager.AddToRole(user.Id, GlobalConstants.UserRole);
                }
            }

        }
    }
}