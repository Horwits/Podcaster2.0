using Podcaster.Models.Contracts;

namespace Podcaster.Models.Factories.Contracts
{
    public interface IModelsFactory
    {
        IApplicationUser CreateUser(string username, string email);
    }
}