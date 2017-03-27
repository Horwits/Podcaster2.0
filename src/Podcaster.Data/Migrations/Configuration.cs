using System;
using System.Data.Entity.Migrations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

using Ploeh.AutoFixture;

using Podcaster.Common.Constants;
using Podcaster.Data.DbContexts;
using Podcaster.Models;

namespace Podcaster.Data.Migrations
{
    [ExcludeFromCodeCoverage]
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

            /*this.SeedRoles(context);*/
            /* this.SeedUsers(context);*/
            /* this.SeedPodcasts(context);*/
        }

        private void SeedPodcasts(PodcasterDbContext context)
        {
            if (!context.Podcasts.Any())
            {
                context.Podcasts.AddOrUpdate(
                    new PodcastEntity()
                        {
                            Id = new Fixture().Create<Guid>(),
                            AuthorName = "Joe Rogan",
                            Copyright = "Talking Monkey Productions",
                            Description = "Conduit to the Gaian Mind",
                            FeedUrl = "http://joeroganexp.joerogan.libsynpro.com/rss",
                            ImageUrl =
                                "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                            Language = "English",
                            Pricing = 0m,
                            Title = "The Joe Rogan Experience - Joe Rogan",
                            IsExplicit = true
                        });
            }
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
            if (context.Users.Any())
            {
                /*var fixture = new Fixture();
                for (int i = 0; i < 10; i++)
                {
                    var mail = $"a{i}b{i * 2}@abv.com";
                    var user = new ApplicationUser { Email = mail, UserName = mail };

                    this.userManager.Create(user, "123456");

                    this.userManager.AddToRole(user.Id, GlobalConstants.UserRole);
                }*/
                var admin = new ApplicationUser("admin@horwits.bg", "admin@horwits.bg");

                this.userManager.Create(admin, "admin#");
                this.userManager.AddToRole(admin.Id, GlobalConstants.AdminRole);
            }
        }
    }
}