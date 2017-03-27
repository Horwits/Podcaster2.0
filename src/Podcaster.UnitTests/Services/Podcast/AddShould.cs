using System;

using NUnit.Framework;

using Podcaster.Services.Podcast;
using Podcaster.UnitTests.Base;
using Podcaster.UnitTests.Mocks;

namespace Podcaster.UnitTests.Services.Podcast
{
    [TestFixture]
    public class DeleteShould : BaseTestClass
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
            Assert.DoesNotThrow(() => sut.Delete(entity));
        }

        [Test]
        public void Throw_WhenArgument_IsNotValid()
        {
            // Arrange
            var fakeEntityFactory = new FakePodcastEntityFactory();
            var repoFaktory = new FakeRepositoriesFactory(fakeEntityFactory);
            var fakeData = new FakePodcasterDataFactory(repoFaktory).GetPodcasterData();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PodcastService(fakeData.Object).Delete(null));
        }

        /*
         //Integration test
                [Test]
                public void Call_AddMethod_OfPodcasterDataOnceWhenArgument_IsValid()
                {
                    // Arrange
                    var fakeRepository = new Mock<IRepository<PodcastEntity>>();
                    fakeRepository.Setup(x => x.Add(It.IsAny<PodcastEntity>()));
                    var fakeData = new Mock<IPodcasterDataEF>();
                    fakeData.Setup(x => x.Podcasts).Returns(fakeRepository.Object);

                    var entity = new FakePodcastEntityFactory().GetPodcastEntity();
                    var sut = new PodcastService(fakeData.Object);

                    // Act
                    sut.Add(entity);

                    // Assert
                    fakeData.Verify(x => x.Podcasts.Add(It.IsAny<PodcastEntity>()), Times.Once());
                }*/
    }
}