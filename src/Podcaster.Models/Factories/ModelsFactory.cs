using Podcaster.Models.Contracts;
using Podcaster.Models.Factories.Contracts;

namespace Podcaster.Models.Factories
{
    public class ModelsFactory : IModelsFactory
    {
        public IUser CreateUser()
        {
            return new User();
        }
    }
}