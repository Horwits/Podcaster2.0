using System;
using System.Diagnostics.CodeAnalysis;

using Ninject.Extensions.Conventions;
using Ninject.Modules;

using Podcaster.Services.Podcast.Contracts;

namespace Podcaster.CompositionModules.Services
{
    [ExcludeFromCodeCoverage]
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind(x => x.FromAssemblyContaining<IPodcastService>().SelectAllClasses().BindDefaultInterface());
        }
    }
}
