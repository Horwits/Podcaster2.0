using System.Security.Claims;

using Microsoft.AspNet.Identity;

using Moq;

using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.Models.Contracts;
using Podcaster.UnitTests.Base;

namespace Podcaster.UnitTests.Models.ApplicationUser
{
    [TestFixture]
    public class GenerateUserIdentityShould : BaseTestClass
    {
        /*[Test]
        public void Call_CreateIdentity_From_IAppUserManager()
        {
            // Arrange
            var mockAppUserManager = new Mock<IApplicationUserManager>();

            var user = this.Fixture.Create<Podcaster.Models.ApplicationUser>();
           
            mockAppUserManager.Setup(x => x.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie)).Returns(new ClaimsIdentity());

            // Act
            /*user.GenerateUserIdentity(mockAppUserManager.Object);#1#

            // Assert
            mockAppUserManager.Verify(m => m.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie), Times.Once);
        }*/
    }
}