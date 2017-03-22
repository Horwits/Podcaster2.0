using System;

using Microsoft.AspNet.Identity;

using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.Models.Contracts;
using Podcaster.UnitTests.Abstractions;

using IUser = Podcaster.Models.Contracts.IUser;

namespace Podcaster.UnitTests.Models.UserRole
{
    [TestFixture]
    public class SettersShould : BaseTestClass
    {
        [Test]
        public void Set_TheCorrectProperties()
        {
            // Arrange
            IRole<Guid> role = this.Fixture.Create<Podcaster.Models.Role>();
            var roleId = role.Id;
            IUser user = this.Fixture.Create<Podcaster.Models.User>();
            var userId = user.Id;

            // Act
            IUserRole userLogin = new Podcaster.Models.UserRole()
                                      {
                                          RoleId = roleId,
                                          Role = role,
                                          User = user,
                                          UserId = userId
                                      };

            // Assert
            Assert.AreSame(role, userLogin.Role);
            Assert.AreEqual(roleId, userLogin.RoleId);
            Assert.AreSame(user, userLogin.User);
            Assert.AreEqual(userId, userLogin.UserId);
        }
    }
}