using NUnit.Framework;

using Podcaster.Web.Controllers;

using TestStack.FluentMVCTesting;

namespace Podcaster.UnitTests.WebClient.Controllers.Manage
{
    [TestFixture]
    public class AddPhoneNumberShould
    {
        [Test]
        public void RenderDefaultView()
        {
            var controller = new ManageController();
            controller.WithCallTo(x => x.AddPhoneNumber()).ShouldRenderDefaultView();
        }
    }
}
