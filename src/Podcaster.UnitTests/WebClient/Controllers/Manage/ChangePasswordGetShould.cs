using NUnit.Framework;

using Podcaster.Web.Controllers;

using TestStack.FluentMVCTesting;

namespace Podcaster.UnitTests.WebClient.Controllers.Manage
{
    [TestFixture]
    public class ChangePasswordGetShould
    {
        [Test]
        public void Return_DefaultView()
        {
            // Arrange
            var controller = new ManageController();
            
            // Act & Assert
            controller.WithCallTo(x => x.ChangePassword()).ShouldRenderDefaultView();
        }
    }
}
