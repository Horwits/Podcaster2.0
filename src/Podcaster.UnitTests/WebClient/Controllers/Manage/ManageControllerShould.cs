using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

using Moq;

using NUnit.Framework;

using Podcaster.Identity;
using Podcaster.Models;
using Podcaster.UnitTests.Base;
using Podcaster.Web.Controllers;

using TestStack.FluentMVCTesting;

namespace Podcaster.UnitTests.WebClient.Controllers.Manage
{
    [TestFixture]
    public class ManageControllerShould : BaseTestClass
    {
        [Test]
        public void RedirectTo_VerifyPhoneNumber_If_ModelStateIsValid()
        {
            // Arrange
            var mockUserStore = new Mock<IUserStore<ApplicationUser>>().Object;
            var mockAuthManager = new Mock<IAuthenticationManager>().Object;
            var fakeAppUserManager = new ApplicationUserManager(mockUserStore);
            var fakeAppSignInManager = new ApplicationSignInManager(fakeAppUserManager, mockAuthManager);

            var manageController = new ManageController(fakeAppUserManager, fakeAppSignInManager);

            // Act & Assert
            manageController.WithCallTo(m => m.AddPhoneNumber()).ShouldRenderDefaultView();
        }

        [Test]
        public void Return_DefaultView_When_ViewingAddPhoneNumberPage()
        {
            // Arrange
            var mockUserStore = new Mock<IUserStore<ApplicationUser>>().Object;
            var mockAuthManager = new Mock<IAuthenticationManager>().Object;
            var fakeAppUserManager = new ApplicationUserManager(mockUserStore);
            var fakeAppSignInManager = new ApplicationSignInManager(fakeAppUserManager, mockAuthManager);

            var manageController = new ManageController(fakeAppUserManager, fakeAppSignInManager);

            // Act & Assert
            manageController.WithCallTo(m => m.AddPhoneNumber()).ShouldRenderDefaultView();
        }

        /*[Test]
        public void Return_DefaultViewOfAddPhoneNumberPage_When_ModelStateIsValid()
        {
            // Arrange
            var mockUserStore = new Mock<IUserStore<ApplicationUser>>().Object;
            var mockAuthManager = new Mock<IAuthenticationManager>().Object;
            var fakeAppUserManager = new ApplicationUserManager(mockUserStore);
            var fakeAppSignInManager = new ApplicationSignInManager(fakeAppUserManager, mockAuthManager);

            var manageController = new ManageController(fakeAppUserManager, fakeAppSignInManager);
            var validModel = this.Fixture.Create<AddPhoneNumberViewModel>();

            // Act & Assert
            manageController.WithCallTo(m => m.AddPhoneNumber()).ShouldRenderDefaultView().WithModel(validModel);
        }*/
    }
}