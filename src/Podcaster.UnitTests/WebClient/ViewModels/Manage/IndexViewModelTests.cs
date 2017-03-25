using System.Collections.Generic;

using Microsoft.AspNet.Identity;

using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.Web.Models.Manage;

namespace Podcaster.UnitTests.WebClient.ViewModels.Manage
{
    [TestFixture]
    public class IndexViewModelTests : BaseTestClass
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var expectedNumber = this.Fixture.Create<string>();
            var expectedLogins = new List<UserLoginInfo>();
            var sut = new IndexViewModel();

            // Act
            sut.BrowserRemembered = true;
            sut.HasPassword = true;
            sut.PhoneNumber = expectedNumber;
            sut.TwoFactor = true;
            sut.Logins = expectedLogins;

            // Assert
            Assert.AreSame(expectedNumber, sut.PhoneNumber);
            Assert.AreSame(expectedLogins, sut.Logins);
            Assert.AreEqual(true, sut.BrowserRemembered);
            Assert.AreEqual(true, sut.HasPassword);
            Assert.AreEqual(true, sut.TwoFactor);
        }
    }
}