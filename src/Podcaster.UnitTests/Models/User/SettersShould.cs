using System;

using NUnit.Framework;

using Ploeh.AutoFixture;

namespace Podcaster.UnitTests.Models.User
{
    [TestFixture]
    public class SettersShould : BaseTestClass
    {
        [Test]
        public void Set_TheProperties_WhenValid()
        {
            // Arrange
            var accessFailedCount = this.Fixture.Create<int>();
            var createDate = this.Fixture.Create<DateTime>();
            var email = this.Fixture.Create<string>();
            var emailConfirmed = this.Fixture.Create<bool>();

            var id = this.Fixture.Create<Guid>();
            var lockoutEnabled = this.Fixture.Create<bool>();
            var lockoutEndDateUtc = this.Fixture.Create<DateTime>();
            var passwordHash = this.Fixture.Create<string>();
            var phoneNumber = this.Fixture.Create<string>();
            var phoneNumberConfirmed = this.Fixture.Create<bool>();
            var securityStamp = this.Fixture.Create<string>();
            var twoFactorEnabled = this.Fixture.Create<bool>();
            var userName = this.Fixture.Create<string>();

            // Act
            var user = new Podcaster.Models.User
                           {
                               CreateDate = createDate,
                               AccessFailedCount = accessFailedCount,
                               Email = email,
                               EmailConfirmed = emailConfirmed,
                               Id = id,
                               LockoutEnabled = lockoutEnabled,
                               LockoutEndDateUtc = lockoutEndDateUtc,
                               PasswordHash = passwordHash,
                               PhoneNumber = phoneNumber,
                               PhoneNumberConfirmed = phoneNumberConfirmed,
                               SecurityStamp = securityStamp,
                               TwoFactorEnabled = twoFactorEnabled,
                               UserName = userName
                           };

            // Assert
            Assert.AreEqual(createDate, user.CreateDate);
            Assert.AreEqual(accessFailedCount, user.AccessFailedCount);
            Assert.AreSame(email, user.Email);
            Assert.AreEqual(emailConfirmed, user.EmailConfirmed);
            Assert.AreEqual(id, user.Id);
            Assert.AreEqual(lockoutEnabled, user.LockoutEnabled);
            Assert.AreEqual(lockoutEndDateUtc, user.LockoutEndDateUtc);
            Assert.AreSame(passwordHash, user.PasswordHash);
            Assert.AreSame(phoneNumber, user.PhoneNumber);
            Assert.AreEqual(phoneNumberConfirmed, user.PhoneNumberConfirmed);
            Assert.AreSame(securityStamp, user.SecurityStamp);
            Assert.AreEqual(twoFactorEnabled, user.TwoFactorEnabled);
            Assert.AreSame(userName, user.UserName);
        }
    }
}