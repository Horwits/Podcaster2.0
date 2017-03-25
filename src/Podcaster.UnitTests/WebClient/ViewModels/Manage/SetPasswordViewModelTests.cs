using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Manage;

namespace Podcaster.UnitTests.WebClient.ViewModels.Manage
{
    [TestFixture]
    public class SetPasswordModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expectedPass = this.Fixture.Create<string>();
            var expectedConfirm = this.Fixture.Create<string>();
            var sut = new SetPasswordViewModel { NewPassword = expectedPass, ConfirmPassword = expectedConfirm };

            // Act
            // Assert
            Assert.AreSame(expectedPass, sut.NewPassword);
            Assert.AreSame(expectedConfirm, sut.ConfirmPassword);
        }
    }
}