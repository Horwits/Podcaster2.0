using System;
using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNet.Identity;

using Podcaster.Models;
using Podcaster.Services.Identity.Contracts;

namespace Podcaster.Services.Identity
{
    [ExcludeFromCodeCoverage]
    public class ApplicationRoleManager : RoleManager<Role, Guid>
    {
        public ApplicationRoleManager(IRoleStore store)
            : base(store)
        {
        }
    }
}