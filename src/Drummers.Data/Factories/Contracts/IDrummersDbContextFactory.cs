using Drummers.Models.Identity.Models;

using Microsoft.AspNet.Identity.EntityFramework;

namespace Drummers.Data.Factories.Contracts
{
    public interface IDrummersDbContextFactory
    {
        IdentityDbContext<ApplicationUser> GetDbContext();
    }
}
