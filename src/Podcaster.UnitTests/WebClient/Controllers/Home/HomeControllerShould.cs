using NUnit.Framework;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Controllers;

using TestStack.FluentMVCTesting;

namespace Podcaster.UnitTests.WebClient.Controllers.Home
{
    [TestFixture]
    public class HomeControllerShould : BaseTestClass
    {
        [Test]
        public void Return_AboutView_WhenViewingAboutPage()
        {
            // Arrange
            var homeController = new HomeController();

            // Act & Assert
            homeController.WithCallTo(h => h.About()).ShouldRenderDefaultView();
        }

        [Test]
        public void Return_ContactView_WhenViewingContactPage()
        {
            // Arrange
            var homeController = new HomeController();

            // Act & Assert
            homeController.WithCallTo(h => h.Contact()).ShouldRenderDefaultView();
        }

        [Test]
        public void Return_IndexView_WhenViewingIndexPage()
        {
            // Arrange
            var homeController = new HomeController();

            // Act & Assert
            homeController.WithCallTo(h => h.Index()).ShouldRenderDefaultView();
        }
    }
}