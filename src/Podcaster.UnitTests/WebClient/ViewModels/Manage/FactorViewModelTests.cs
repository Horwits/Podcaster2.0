using NUnit.Framework;

using Ploeh.AutoFixture;
using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Manage;

namespace Podcaster.UnitTests.WebClient.ViewModels.Manage
{
    [TestFixture]
    public class FactorViewModelTests : BaseTestClass
    {
        [Test]
        public void SettetrShouldSetAllProperties()
        {
            // Arrange
            var puropse = this.Fixture.Create<string>();

            // Act
            var sut = new FactorViewModel
            {
                Purpose = puropse
            };

            // Assert
            Assert.AreSame(puropse, sut.Purpose);
        }
    }
}
