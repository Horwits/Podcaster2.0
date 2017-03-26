using Moq;

using Podcaster.Data.DataEF.Contracts;
using Podcaster.Data.Repositories.Contracts;
using Podcaster.Models;
using Podcaster.Models.Contracts;

namespace Podcaster.UnitTests.Services.Mocks
{
    internal class FakePodcasterDataFactory 
    {
        private readonly FakeRepositoriesFactory fakeRepositoriesFactory;

        private readonly FakePodcastEntityFactory fakePodcastEntityFactory;

        internal FakePodcasterDataFactory(FakeRepositoriesFactory fakeRepositoriesFactory, FakePodcastEntityFactory fakePodcastEntityFactory)
        {
            this.fakeRepositoriesFactory = fakeRepositoriesFactory;
            this.fakePodcastEntityFactory = fakePodcastEntityFactory;
        }

        internal IMock<IPodcasterDataEF> GetPodcasterData()
        {
            var fakeData = new Mock<IPodcasterDataEF>();

            var fakePodcastRepo = this.fakeRepositoriesFactory.GetPodcastRepository().Object;

            fakeData.Setup(x => x.Podcasts)
                .Returns((IRepository<PodcastEntity>)fakePodcastRepo);

            return fakeData;
        }
    }
}
