using System;

using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.Models.Contracts;
using Podcaster.UnitTests.Abstractions;

namespace Podcaster.UnitTests.Models.UserClaim
{
    [TestFixture]
    public class SettersShould : BaseTestClass
    {
        [Test]
        public void SetTheProperties_WhenValid()
        {
            // Arrange
            var claimType = this.Fixture.Create<string>();
            var claimValue = this.Fixture.Create<string>();
            var id = this.Fixture.Create<Guid>();
            IUser user = this.Fixture.Create<Podcaster.Models.User>();
            var userId = user.Id;

            // Act
            IUserClaim userClaim = new Podcaster.Models.UserClaim()
                                       {
                                           ClaimType = claimType,
                                           ClaimValue = claimValue,
                                           Id = id,
                                           User = user,
                                           UserId = userId
                                       };

            // Assert
            Assert.AreSame(claimType, userClaim.ClaimType);
            Assert.AreSame(claimValue, userClaim.ClaimValue);
            Assert.AreEqual(id, userClaim.Id);
            Assert.AreSame(user, userClaim.User);
            Assert.AreEqual(userId, userClaim.UserId);
        }
    }
}