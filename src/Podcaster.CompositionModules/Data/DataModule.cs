using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;

using Ninject.Extensions.Conventions;
using Ninject.Modules;
using Ninject.Web.Common;

using Podcaster.Data.DbContexts;
using Podcaster.Data.Repositories.Contracts;

namespace Podcaster.CompositionModules.Data
{
    [ExcludeFromCodeCoverage]
    public class DataModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<DbContext>().To<PodcasterDbContext>().InRequestScope();

            this.Bind(x => x.FromAssemblyContaining<IRepository<object>>().SelectAllClasses().BindAllInterfaces());
        }
    }
}