using Moq;
using NUnit.Framework;
using Podcaster.Data.DataEF.Contracts;
using Podcaster.Models;
using Podcaster.Services.User;
using Podcaster.UnitTests.Base;

using Ploeh.AutoFixture;
using System;
using Podcaster.Data.Repositories.Contracts;

namespace Podcaster.UnitTests.Services.User
{
    [TestFixture]
    public class AddShould : BaseTestClass
    {
        [Test]
        public void Throw_WhenArgument_IsNotValid()
        {
            var fakeData = new Mock<IPodcasterDataEF>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new UserService(fakeData.Object).Add(null));
        }

        [Test]
        public void NotThrow_WhenArgument_IsNotValid()
        {
            // Arrange
            var fakeRepository = new Mock<IRepository<ApplicationUser>>();
            var fakeData = new Mock<IPodcasterDataEF>();
            fakeData.Setup(x => x.Users).Returns(fakeRepository.Object);

            var sut = new UserService(fakeData.Object);
            var entity = this.Fixture.Build<Podcaster.Models.ApplicationUser>().Without(p => p.Subscriptions).Create();    

            // Act & Assert
            Assert.DoesNotThrow(() => sut.Add(entity));
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