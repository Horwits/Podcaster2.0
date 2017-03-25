using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Account;

namespace Podcaster.UnitTests.WebClient.ViewModels.Account
{
    [TestFixture]
    public class VerifyCodeViewModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expectedUrl = this.Fixture.Create<string>();
            var expectedProvider = this.Fixture.Create<string>();
            var expectedCode = this.Fixture.Create<string>();
            var sut = new VerifyCodeViewModel();

            // Act
            sut.ReturnUrl = expectedUrl;
            sut.RememberMe = true;
            sut.Provider = expectedProvider;
            sut.RememberBrowser = true;
            sut.Code = expectedCode;

            // Assert
            Assert.AreSame(expectedUrl, sut.ReturnUrl);
            Assert.AreSame(expectedProvider, sut.Provider);
            Assert.AreSame(expectedCode, sut.Code);
            Assert.AreEqual(true, sut.RememberMe);
            Assert.AreEqual(true, sut.RememberBrowser);
        }
    }
}