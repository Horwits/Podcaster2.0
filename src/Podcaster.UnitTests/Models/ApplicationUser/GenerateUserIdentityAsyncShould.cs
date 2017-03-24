using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;

using Moq;

using Ploeh.AutoFixture;

using Podcaster.Models.Contracts;
using Podcaster.UnitTests.Base;

namespace Podcaster.UnitTests.Models.ApplicationUser
{
    [TestFixture]
    public class GenerateUserIdentityAsyncShould : BaseTestClass
    {
        [Test]
        public void Call_GenerateUserIdentity_Once()
        {
            // Arrange
            var userStore = new Mock<IUserStore<Podcaster.Models.ApplicationUser>>();

            var userManager = new Mock<UserManager<Podcaster.Models.ApplicationUser>>(userStore.Object);

            var authType = this.Fixture.Create<string>();
            var user = this.Fixture.Create<Podcaster.Models.ApplicationUser>();

            // Act
            var result = user.GenerateUserIdentityAsync(userManager.Object);

            // Assert
            /*  userManager.Verify(m => m.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie), Times.Once);*/
            Assert.IsInstanceOf(typeof(Task<ClaimsIdentity>), result);
        }
    }
}
