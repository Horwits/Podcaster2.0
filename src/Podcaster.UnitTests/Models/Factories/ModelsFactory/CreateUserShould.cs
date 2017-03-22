using NUnit.Framework;

using Podcaster.Models.Contracts;

namespace Podcaster.UnitTests.Models.Factories.ModelsFactory
{
    [TestFixture]
    public class CreateUserShould
    {
        [Test]
        public static void Create_AnInstanceOf_IUser_WhenIsCalled()
        {
            // Arrange
            var modelsFactory = new Podcaster.Models.Factories.ModelsFactory();

            // Act
            var user = modelsFactory.CreateUser();

            // Assert
            Assert.IsInstanceOf<IUser>(user);
        }
    }
}