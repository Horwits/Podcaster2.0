using System;

using Moq;

using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.Data.DataEF.Contracts;
using Podcaster.Data.Repositories.Contracts;
using Podcaster.Models;
using Podcaster.Services.User;
using Podcaster.UnitTests.Base;

namespace Podcaster.UnitTests.Services.User
{
    [TestFixture]
    public class UpdateShould : BaseTestClass
    {
        [Test]
        public void NotThrow_WhenArgument_IsNotValid()
        {
            // Arrange
            var fakeRepository = new Mock<IRepository<ApplicationUser>>();
            var fakeData = new Mock<IPodcasterDataEF>();
            fakeData.Setup(x => x.Users).Returns(fakeRepository.Object);
            var sut = new UserService(fakeData.Object);

            var entity = this.Fixture.Build<ApplicationUser>().Without(p => p.Subscriptions).Create();

            // Act & Assert
            Assert.DoesNotThrow(() => sut.Update(entity));
        }

        [Test]
        public void Throw_WhenArgument_IsNotValid()
        {
            // Arrange
            var fakeData = new Mock<IPodcasterDataEF>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new UserService(fakeData.Object).Update(null));
        }

        /*[Test]
        public void Call_AddMethod_OfPodcasterDataOnceWhenArgument_IsValid()
        {
            // Arrange
            var fakeEntityFactory = new FakePodcastEntityFactory();
            var repoFactory = new FakeRepositoriesFactory(fakeEntityFactory);
            IMock<IPodcasterDataEF> fakeData = new FakePodcasterDataFactory(It.IsAny<FakeRepositoriesFactory>()).GetPodcasterData();

            var entity = fakeEntityFactory.GetPodcastEntity();
            var sut = new PodcastService(fakeData.Object);

            // Act & Assert
            sut.Add(entity);
            fakeData.Verify(() => fakeData.Object.Podcasts.Add(entity), Times.Once());
        }*/

        // Arrange
        // Act
        // Assert
        /*[Test]
        public void Throw_WhenArgument_IsNull()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PodcastService(null));
        }*/
    }
}