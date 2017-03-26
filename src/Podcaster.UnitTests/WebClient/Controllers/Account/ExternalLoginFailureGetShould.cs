using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Podcaster.Web.Controllers;

using TestStack.FluentMVCTesting;

namespace Podcaster.UnitTests.WebClient.Controllers.Account
{
    [TestFixture]
    public class ExternalLoginFailureGetShould
    {
        [Test]
        public void RenderDefaultView()
        {
            var controller = new AccountController();
            controller.WithCallTo(x => x.ExternalLoginFailure()).ShouldRenderDefaultView();
        }
    }
}
