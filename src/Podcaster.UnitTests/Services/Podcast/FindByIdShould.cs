using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ploeh.AutoFixture;

using Podcaster.Services.Podcast;
using Podcaster.UnitTests.Base;
using Podcaster.UnitTests.Services.Mocks;

namespace Podcaster.UnitTests.Services.Podcast
{
    [TestFixture]
    public class FindByIdShould : BaseTestClass
    {
        [Test]
        public void Throw_WhenArgument_IsNotValid()
        {
            // Arrange
            var fakeEntityFactory = new FakePodcastEntityFactory();
            var repoFaktory = new FakeRepositoriesFactory(fakeEntityFactory);
            var fakeData = new FakePodcasterDataFactory(repoFaktory).GetPodcasterData();

            var guid = Guid.Empty;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new PodcastService(fakeData.Object).FindById(guid));
        }

        [Test]
        public void NotThrow_WhenArgument_IsValid()
        {
            // Arrange
            var fakeEntityFactory = new FakePodcastEntityFactory();
            var repoFaktory = new FakeRepositoriesFactory(fakeEntityFactory);
            var fakeData = new FakePodcasterDataFactory(repoFaktory).GetPodcasterData();

            var guid = this.Fixture.Create<Guid>();

            // Act & Assert
            Assert.DoesNotThrow(() => new PodcastService(fakeData.Object).FindById(guid));
        }
    }
}
