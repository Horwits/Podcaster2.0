using Podcaster.Models.Contracts;

namespace Podcaster.Models.Factories.Contracts
{
    public interface IModelsFactory
    {
        IUser CreateUser();
    }
}