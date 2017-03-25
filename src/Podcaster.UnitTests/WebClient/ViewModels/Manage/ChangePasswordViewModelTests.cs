using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Manage;

namespace Podcaster.UnitTests.WebClient.ViewModels.Manage
{
    [TestFixture]
    public class ChangePasswordViewModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expectedOld = this.Fixture.Create<string>();
            var expectedConfirm = this.Fixture.Create<string>();
            var expectedNew = this.Fixture.Create<string>();
            var sut = new ChangePasswordViewModel();

            // Act
            sut.ConfirmPassword = expectedConfirm;
            sut.OldPassword = expectedOld;
            sut.NewPassword = expectedNew;

            // Assert
            Assert.AreSame(expectedConfirm, sut.ConfirmPassword);
            Assert.AreSame(expectedOld, sut.OldPassword);
            Assert.AreSame(expectedNew, sut.NewPassword);
        }
    }
}