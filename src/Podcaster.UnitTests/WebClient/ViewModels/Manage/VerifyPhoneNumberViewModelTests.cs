using NUnit.Framework;

using Ploeh.AutoFixture;
using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Manage;

namespace Podcaster.UnitTests.WebClient.ViewModels.Manage
{
    [TestFixture]
    public class VerifyPhoneNumberViewModelTests : BaseTestClass
    {
        [Test]
        public void SettetrShouldSetAllProperties()
        {
            // Arrange
            var code = this.Fixture.Create<string>();
            var phoneNumber = this.Fixture.Create<string>();

            // Act
            var sut = new VerifyPhoneNumberViewModel()
            {
                Code = code,
                PhoneNumber = phoneNumber
            };

            // Assert
            Assert.AreSame(code, sut.Code);
            Assert.AreSame(phoneNumber, sut.PhoneNumber);
        }
    }
}
