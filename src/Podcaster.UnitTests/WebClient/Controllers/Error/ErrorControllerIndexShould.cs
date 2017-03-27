using NUnit.Framework;

using Podcaster.Web.Areas.Error.Controllers;

using TestStack.FluentMVCTesting;

namespace Podcaster.UnitTests.WebClient.Controllers.Error
{
    [TestFixture]
    public class ErrorControllerIndexShould
    {
        [Test]
        public void Return_DefaultView_WhenCalled()
        {
            // Arrange
            var homeController = new ErrorController();

            // Act & Assert
            homeController.WithCallTo(h => h.Index()).ShouldRenderView("Error");
        }
    }
}