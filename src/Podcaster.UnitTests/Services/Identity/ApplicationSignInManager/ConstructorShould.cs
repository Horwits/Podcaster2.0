using NUnit.Framework;

using Podcaster.UnitTests.Abstractions;

namespace Podcaster.UnitTests.Services.Identity.ApplicationSignInManager
{
    [TestFixture]
    public class ConstructorShould : BaseTestClass
    {
        /*[Test]
        public void SetNeededProperties_WithNeededTypes()
        {
            // Arrange
            this.Fixture.Register<IUserStore>(() => new UserStore());

            var fakeApplicationUserManager = this.Fixture.Build<ApplicationUserManager>().With(x=>x.UserStore)Create<ApplicationUserManager>();
            var fakeAuthManager = new Mock<IAuthenticationManager>();

            var applicationSignInManager =
                new Podcaster.Services.Identity.ApplicationSignInManager(
                    fakeApplicationUserManager,
                    fakeAuthManager.Object);

            // Act & Assert
            Assert.IsInstanceOf<ApplicationUserManager>(applicationSignInManager.UserManager);
            Assert.IsInstanceOf<IAuthenticationManager>(applicationSignInManager.AuthenticationManager);
        }*/
    }
}