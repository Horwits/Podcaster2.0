using System.Collections.Generic;
using System.Web.Mvc;

using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Manage;

namespace Podcaster.UnitTests.WebClient.ViewModels.Manage
{
    [TestFixture]
    public class ConfigureTwoFactorViewModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expectedProvider = this.Fixture.Create<string>();
            var expectedProviders = new List<SelectListItem>();
            var sut = new ConfigureTwoFactorViewModel();

            // Act
            sut.SelectedProvider = expectedProvider;
            sut.Providers = expectedProviders;

            // Assert
            Assert.AreSame(expectedProvider, sut.SelectedProvider);
            Assert.AreSame(expectedProviders, sut.Providers);
        }
    }
}