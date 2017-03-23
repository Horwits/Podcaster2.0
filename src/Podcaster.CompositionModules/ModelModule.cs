using Ninject.Extensions.Conventions;
using Ninject.Modules;

namespace Podcaster.CompositionModules
{
    public class ModelModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind(x => x.FromAssembliesMatching("Podcaster.Models").SelectAllClasses().BindAllInterfaces());
        }
    }
}