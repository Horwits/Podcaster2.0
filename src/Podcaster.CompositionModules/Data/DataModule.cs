using Ninject.Extensions.Conventions;
using Ninject.Modules;

using Podcaster.Data.Repositories.Contracts;

namespace Podcaster.CompositionModules.Data
{
    public class DataModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind(x => x.FromAssemblyContaining<IRepository<object>>().SelectAllClasses().BindAllInterfaces());
        }
    }
}