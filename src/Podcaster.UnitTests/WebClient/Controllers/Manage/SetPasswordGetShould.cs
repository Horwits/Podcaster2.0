    using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    using Podcaster.Web.Controllers;

    using TestStack.FluentMVCTesting;

namespace Podcaster.UnitTests.WebClient.Controllers.Manage
{
    [TestFixture]
    public class SetPasswordGetShould
    {
        [Test]
        public void RenderDefaultView()
        {
            var controller = new ManageController();
            controller.WithCallTo(x => x.SetPassword()).ShouldRenderDefaultView();
        }
    }
}
