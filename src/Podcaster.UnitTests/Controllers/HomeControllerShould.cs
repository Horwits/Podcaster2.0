using NUnit.Framework;

using Podcaster.UnitTests.Abstractions;
using Podcaster.WebClient.Controllers;

using TestStack.FluentMVCTesting;

namespace Podcaster.UnitTests.Controllers
{
    [TestFixture]
    public class HomeControllerShould : BaseTestClass
    {

        [Test]
        public void Return_IndexView_WhenViewingIndexPage()
        {
            // Arrange
            var homeController = new HomeController();

            // Act & Assert
            homeController.WithCallTo(h => h.Index())
                .ShouldRenderDefaultView();
        }

        [Test]
        public void Return_AboutView_WhenViewingAboutPage()
        {
            // Arrange
            var homeController = new HomeController();

            // Act & Assert
            homeController.WithCallTo(h => h.About())
                .ShouldRenderDefaultView();
        }

        [Test]
        public void Return_ContactView_WhenViewingContactPage()
        {
            // Arrange
            var homeController = new HomeController();

            // Act & Assert
            homeController.WithCallTo(h => h.Contact())
                .ShouldRenderDefaultView();
        }
    }
}
