using System;

using Moq;

using NUnit.Framework;

using Podcaster.Data.DataEF.Contracts;
using Podcaster.Services.User;
using Podcaster.UnitTests.Base;

namespace Podcaster.UnitTests.Services.User
{
    [TestFixture]
    public class ConstructorShould : BaseTestClass
    {
        [Test]
        public void NotThrow_WhenArgument_IsValid()
        {
            // Arrange
            var fakeData = new Mock<IPodcasterDataEF>().Object;

            // Act & Assert
            Assert.DoesNotThrow(() => new UserService(fakeData));
        }

        // Arrange
        // Act
        // Assert
        [Test]
        public void Throw_WhenArgument_IsNull()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new UserService(null));
        }
    }
}