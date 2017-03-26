using System;

using Moq;

using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.Data.DataEF.Contracts;
using Podcaster.Data.Repositories.Contracts;
using Podcaster.Models;
using Podcaster.Services.Podcast;
using Podcaster.Services.User;
using Podcaster.UnitTests.Base;
using Podcaster.UnitTests.Services.Mocks;

namespace Podcaster.UnitTests.Services.User
{
    [TestFixture]
    public class FindByIdShould : BaseTestClass
    {
        [Test]
        public void Throw_WhenArgument_IsNotValid()
        {
            // Arrange
            var fakeData = new Mock<IPodcasterDataEF>().Object;
            var sut = new UserService(fakeData);
            var guid = Guid.Empty;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.FindById(guid));
        }

        [Test]
        public void NotThrow_WhenArgument_IsValid()
        {
            // Arrange
            var fakeRepository = new Mock<IRepository<ApplicationUser>>();
            var fakeData = new Mock<IPodcasterDataEF>();
            fakeData.Setup(x => x.Users).Returns(fakeRepository.Object);

            var sut = new UserService(fakeData.Object);

            var guid = this.Fixture.Create<Guid>();
            
            // Act & Assert
            Assert.DoesNotThrow(() => sut.FindById(guid));
        }
    }
}
