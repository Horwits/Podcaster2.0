using System;

using Moq;

using NUnit.Framework;

using Podcaster.Services.Podcast;
using Podcaster.UnitTests.Base;
using Podcaster.UnitTests.Mocks;

namespace Podcaster.UnitTests.Services.Podcast
{
    [TestFixture]
    public class UpdateShould : BaseTestClass
    {
        [Test]
        public void Throw_WhenArgument_IsNotValid()
        {
            // Arrange
            var fakeEntityFactory = new FakePodcastEntityFactory();
            var repoFaktory = new FakeRepositoriesFactory(fakeEntityFactory);
            var fakeData = new FakePodcasterDataFactory(repoFaktory).GetPodcasterData();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PodcastService(fakeData.Object).Update(null));
        }

        [Test]
        public void NotThrow_WhenArgument_IsNotValid()
        {
            // Arrange
            var fakeEntityFactory = new FakePodcastEntityFactory();
            var repoFaktory = new FakeRepositoriesFactory(fakeEntityFactory);
            var fakeData = new FakePodcasterDataFactory(repoFaktory).GetPodcasterData();
            var sut = new PodcastService(fakeData.Object);
            var entity = fakeEntityFactory.GetPodcastEntity();

            // Act & Assert
            Assert.DoesNotThrow(() => sut.Update(entity));
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