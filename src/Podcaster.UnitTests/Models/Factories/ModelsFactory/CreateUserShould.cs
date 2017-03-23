using System;

using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.Models.Contracts;
using Podcaster.UnitTests.Abstractions;

namespace Podcaster.UnitTests.Models.Factories.ModelsFactory
{
    [TestFixture]
    public class CreateUserShould : BaseTestClass
    {
        [Test]
        public void Create_AnInstanceOf_IUser_WhenIsCalled_WithCorrectName()
        {
            // Arrange
            var name = this.Fixture.Create<string>();
            var email = this.Fixture.Create<string>();

            var modelsFactory = new Podcaster.Models.Factories.ModelsFactory();

            // Act
            var user = modelsFactory.CreateUser(name, email);

            // Assert
            Assert.IsInstanceOf<IApplicationUser>(user);
        }

        [TestCase(null, "mail")]
        [TestCase("name", "")]
        [TestCase("name", null)]
        [TestCase("", "mail")]
        public void Throw_ArgumentException_WhenIsCalled_WithInCorrectName(string name, string email)
        {
            // Arrange
            var modelsFactory = new Podcaster.Models.Factories.ModelsFactory();

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => modelsFactory.CreateUser(name, email));
        }
    }
}