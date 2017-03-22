using System;

using Microsoft.AspNet.Identity;

using Podcaster.Models;

namespace Podcaster.Services.Identity.Contracts
{
    public interface IUserStore : IUserLoginStore<User, Guid>,
                                  IUserClaimStore<User, Guid>,
                                  IUserRoleStore<User, Guid>,
                                  IUserPasswordStore<User, Guid>,
                                  IUserSecurityStampStore<User, Guid>,
                                  IUserEmailStore<User, Guid>,
                                  IUserPhoneNumberStore<User, Guid>,
                                  IUserTwoFactorStore<User, Guid>,
                                  IUserLockoutStore<User, Guid>
    {
    }
}