using Drummers.Data.Factories.Contracts;
using Drummers.Models.Identity.Models;

using Microsoft.AspNet.Identity.EntityFramework;

namespace Drummers.Data.Factories
{
    public class DrummersDbContextFactory : IDrummersDbContextFactory
    {
        public IdentityDbContext<ApplicationUser> GetDbContext()
        {
            return new ApplicationDbContext();
        }
    }
}
