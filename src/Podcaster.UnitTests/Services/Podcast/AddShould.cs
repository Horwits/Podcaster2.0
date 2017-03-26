using System;

using Moq;

using NUnit.Framework;

using Podcaster.Data.DataEF.Contracts;
using Podcaster.Services.Podcast;
using Podcaster.UnitTests.Base;
using Podcaster.UnitTests.Services.Mocks;

namespace Podcaster.UnitTests.Services.Podcast
{
    [TestFixture]
    public class AddShould : BaseTestClass
    {
        [Test]
        public void Throw_WhenArgument_IsValid()
        {
            // Arrange
            var repoFaktory = new FakeRepositoriesFactory();
            var fakeData = new FakePodcasterDataFactory(repoFaktory).GetPodcasterData();
            var sut = new PodcastService(fakeData.Object);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PodcastService(fakeData.Object).Add(null));
        }

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