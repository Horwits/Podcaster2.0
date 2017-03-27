using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Manage;

namespace Podcaster.UnitTests.WebClient.ViewModels.Manage
{
    [TestFixture]
    public class AddPhoneNumberViewModelTests : BaseTestClass
    {
        [Test]
        public void SettetrShouldSetAllProperties()
        {
            // Arrange
            var phoneNumber = this.Fixture.Create<string>();

            // Act
            var sut = new AddPhoneNumberViewModel() { Number = phoneNumber };

            // Assert
            Assert.AreSame(phoneNumber, sut.Number);
        }
    }
}