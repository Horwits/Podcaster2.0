using Ninject.Modules;

using Podcaster.Data.DbContexts;
using Podcaster.Data.DbContexts.Contracts;

namespace Podcaster.CompositionModules.Auth
{
    public class DataModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IPodcasterDbContext>().To<PodcasterDbContext>();
        }
    }
}
