using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Account;

namespace Podcaster.UnitTests.WebClient.ViewModels.Account
{
    [TestFixture]
    public class ExternalLoginListViewModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expected = this.Fixture.Create<string>();
            var sut = new ExternalLoginListViewModel();

            // Act
            sut.ReturnUrl = expected;

            // Assert
            Assert.AreSame(expected, sut.ReturnUrl);
        }
    }
}