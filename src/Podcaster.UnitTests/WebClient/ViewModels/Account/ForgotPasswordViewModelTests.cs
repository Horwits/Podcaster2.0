using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Account;

namespace Podcaster.UnitTests.WebClient.ViewModels.Account
{
    [TestFixture]
    public class ForgotPasswordViewModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expected = this.Fixture.Create<string>();
            var sut = new ForgotPasswordViewModel();

            // Act
            sut.Email = expected;

            // Assert
            Assert.AreSame(expected, sut.Email);
        }
    }
}