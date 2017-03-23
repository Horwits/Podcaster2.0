using Podcaster.Data.DbContexts.Contracts;

namespace Podcaster.Data.Repositories.Base
{
    public abstract class BaseRepository
    {
        private readonly IPodcasterDbContext context;

        protected BaseRepository(IPodcasterDbContext context)
        {
            this.context = context;
        }

        protected IPodcasterDbContext Context
        {
            get
            {
                return this.context;
            }
        }
    }
}