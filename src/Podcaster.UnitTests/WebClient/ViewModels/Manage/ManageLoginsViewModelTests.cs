using System.Collections.Generic;

using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

using NUnit.Framework;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Manage;

namespace Podcaster.UnitTests.WebClient.ViewModels.Manage
{
    [TestFixture]
    public class ManageLoginsModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expectedOther = new List<AuthenticationDescription>();
            var expectedLogins = new List<UserLoginInfo>();
            var sut = new ManageLoginsViewModel();

            // Act
            sut.CurrentLogins = expectedLogins;
            sut.OtherLogins = expectedOther;

            // Assert
            Assert.AreSame(expectedLogins, sut.CurrentLogins);
            Assert.AreSame(expectedOther, sut.OtherLogins);
        }
    }
}