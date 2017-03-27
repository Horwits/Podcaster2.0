using System;

using NUnit.Framework;

using Podcaster.Services.Podcast;
using Podcaster.UnitTests.Base;
using Podcaster.UnitTests.Mocks;

namespace Podcaster.UnitTests.Services.Podcast
{
    [TestFixture]
    public class AddShould : BaseTestClass
    {
        [Test]
        public void DoesNotThrow_WhenArgument_IsNotValid()
        {
            // Arrange
            var fakeEntityFactory = new FakePodcastEntityFactory();
            var repoFaktory = new FakeRepositoriesFactory(fakeEntityFactory);
            var fakeData = new FakePodcasterDataFactory(repoFaktory).GetPodcasterData();
            var sut = new PodcastService(fakeData.Object);
            var entity = fakeEntityFactory.GetPodcastEntity();

            // Act & Assert
            Assert.DoesNotThrow(() => sut.Add(entity));
        }

        [Test]
        public void Throw_WhenArgument_IsNotValid()
        {
            // Arrange
            var fakeEntityFactory = new FakePodcastEntityFactory();
            var repoFaktory = new FakeRepositoriesFactory(fakeEntityFactory);
            var fakeData = new FakePodcasterDataFactory(repoFaktory).GetPodcasterData();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PodcastService(fakeData.Object).Add(null));
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