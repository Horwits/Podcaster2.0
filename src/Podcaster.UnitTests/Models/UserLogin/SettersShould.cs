using System;

using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Abstractions;

namespace Podcaster.UnitTests.Models.UserLogin
{
    [TestFixture]
    public class SettersShould : BaseTestClass
    {
        [Test]
        public void Set_TheCorrectProperties()
        {
            // Arrange
            var loginProvider = this.Fixture.Create<string>();
            var providerKey = this.Fixture.Create<string>();
            var user = this.Fixture.Create<Podcaster.Models.User>();
            var userId = this.Fixture.Create<Guid>();

            // Act
            var userLogin = new Podcaster.Models.UserLogin()
                                {
                                    LoginProvider = loginProvider,
                                    ProviderKey = providerKey,
                                    User = user,
                                    UserId = userId
                                };

            // Assert
            Assert.AreSame(loginProvider, userLogin.LoginProvider);
            Assert.AreSame(providerKey, userLogin.ProviderKey);
            Assert.AreSame(user, userLogin.User);
            Assert.AreEqual(userId, userLogin.UserId);
        }
    }
}