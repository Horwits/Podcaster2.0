using System;

using Microsoft.AspNet.Identity;

using Podcaster.Models;

namespace Podcaster.Services.Identity.Contracts
{
    public interface IRoleStore : IRoleStore<Role, Guid>
    {
    }
}