using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Account;

namespace Podcaster.UnitTests.WebClient.ViewModels.Account
{
    [TestFixture]
    public class ExternalLoginConfirmationViewModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expectedEmail = this.Fixture.Create<string>();
            var sut = new ExternalLoginConfirmationViewModel();

            // Act
            sut.Email = expectedEmail;

            // Assert
            Assert.AreSame(expectedEmail, sut.Email);
        }
    }
}