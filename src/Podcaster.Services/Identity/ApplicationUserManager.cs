using System;
using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.DataProtection;

using Podcaster.Models;
using Podcaster.Services.Identity.Contracts;

namespace Podcaster.Services.Identity
{
    [ExcludeFromCodeCoverage]
    public class ApplicationUserManager : UserManager<User, Guid>
    {
        private const string BodyFormat = "Your security code is {0}";

        private const string SecurityCode = "Security Code";

        private const string TokenProvider = "ASP.NET Identity";

        public ApplicationUserManager(IUserStore store)
            : base(store)
        {
        }

        public static ApplicationUserManager Create(IUserStore store, IDataProtectionProvider dataProtectionProvider)
        {
            var manager = new ApplicationUserManager(store);

            // Configure validation logic for usernames
            manager.UserValidator = new UserValidator<User, Guid>(manager)
                                        {
                                            AllowOnlyAlphanumericUserNames = false,
                                            RequireUniqueEmail = true
                                        };

            // Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
                                            {
                                                RequiredLength = 6,
                                                RequireNonLetterOrDigit = true,
                                                RequireDigit = true,
                                                RequireLowercase = true,
                                                RequireUppercase = true,
                                            };

            // Configure user lockout defaults
            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;

            // Register two factor authentication providers. This application uses Phone and Emails as a step of receiving a code for verifying the user
            // You can write your own provider and plug it in here.
            manager.RegisterTwoFactorProvider(
                "Phone Code",
                new PhoneNumberTokenProvider<User, Guid> { MessageFormat = BodyFormat });
            manager.RegisterTwoFactorProvider(
                "Email Code",
                new EmailTokenProvider<User, Guid> { Subject = SecurityCode, BodyFormat = BodyFormat });
            manager.EmailService = new EmailService();
            manager.SmsService = new SmsService();

            manager.UserTokenProvider =
                new DataProtectorTokenProvider<User, Guid>(dataProtectionProvider.Create(TokenProvider));

            return manager;
        }
    }
}