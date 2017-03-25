using System.Collections.Generic;
using System.Web.Mvc;

using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Account;

namespace Podcaster.UnitTests.WebClient.ViewModels.Account
{
    [TestFixture]
    public class SendCodeViewModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expectedUrl = this.Fixture.Create<string>();
            var expectedProvider = this.Fixture.Create<string>();
            var expectedProviders = new List<SelectListItem>();
            var sut = new SendCodeViewModel();

            // Act
            sut.ReturnUrl = expectedUrl;
            sut.SelectedProvider = expectedProvider;
            sut.RememberMe = true;
            sut.Providers = expectedProviders;

            // Assert
            Assert.AreSame(expectedUrl, sut.ReturnUrl);
            Assert.AreSame(expectedProvider, sut.SelectedProvider);
            Assert.AreSame(expectedProviders, sut.Providers);
            Assert.AreEqual(true, sut.RememberMe);
        }
    }
}