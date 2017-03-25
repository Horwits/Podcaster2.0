using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Account;

namespace Podcaster.UnitTests.WebClient.ViewModels.Account
{
    [TestFixture]
    public class RegisterViewModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expected = this.Fixture.Create<string>();
            var expectedpass = this.Fixture.Create<string>();
            var sut = new RegisterViewModel();

            // Act
            sut.Email = expected;
            sut.Password = expectedpass;
            sut.ConfirmPassword = expectedpass;

            // Assert
            Assert.AreSame(expected, sut.Email);
            Assert.AreSame(expectedpass, sut.Password);
            Assert.AreSame(expectedpass, sut.ConfirmPassword);
        }
    }
}