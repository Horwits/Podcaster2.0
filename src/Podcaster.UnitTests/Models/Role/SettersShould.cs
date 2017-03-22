using System;

using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Abstractions;

namespace Podcaster.UnitTests.Models.Role
{
    [TestFixture]
    public class SettersShould : BaseTestClass
    {
        [Test]
        public void Set_TheProperties_WhenValid()
        {
            // Arrange
            var id = this.Fixture.Create<Guid>();
            var name = this.Fixture.Create<string>();

            // Act
            var role = new Podcaster.Models.Role() { Id = id, Name = name };

            // Assert
            Assert.AreEqual(id, role.Id);
            Assert.AreSame(name, role.Name);
        }
    }
}