using System;

using Podcaster.Models.Contracts;
using Podcaster.Models.Factories.Contracts;

namespace Podcaster.Models.Factories
{
    public class ModelsFactory : IModelsFactory
    {
        public IApplicationUser CreateUser(string username, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                throw new ArgumentException(nameof(username));
            }

            return new ApplicationUser(username, email);
        }
    }
}