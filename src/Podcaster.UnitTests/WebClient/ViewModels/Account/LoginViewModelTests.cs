using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Account;

namespace Podcaster.UnitTests.WebClient.ViewModels.Account
{
    [TestFixture]
    public class LoginViewModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expected = this.Fixture.Create<string>();
            var expectedpass = this.Fixture.Create<string>();
            var sut = new LoginViewModel();

            // Act
            sut.Email = expected;
            sut.Password = expectedpass;
            sut.RememberMe = true;

            // Assert
            Assert.AreEqual(true, sut.RememberMe);
            Assert.AreSame(expected, sut.Email);
            Assert.AreSame(expectedpass, sut.Password);
        }
    }
}