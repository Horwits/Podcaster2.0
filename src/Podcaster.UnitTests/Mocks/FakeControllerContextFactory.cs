using System.Security.Principal;
using System.Web.Mvc;
using Moq;

namespace Podcaster.UnitTests.Mocks
{
    public class FakeControllerContextFactory
    {
        public IMock<ControllerContext> GetFakeControllerContext(bool isAuthenticated)
        {
            var controllerContext = new Mock<ControllerContext>();
            var principal = new Moq.Mock<IPrincipal>();
            principal.Setup(x => x.Identity.IsAuthenticated).Returns(isAuthenticated);
            controllerContext.SetupGet(x => x.HttpContext.User).Returns(principal.Object);

            return controllerContext;
        }
    }
}
