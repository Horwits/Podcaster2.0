using System.Diagnostics.CodeAnalysis;

using Moq;

using Podcaster.Data.DataEF.Contracts;

namespace Podcaster.UnitTests.Services.Mocks
{
    [ExcludeFromCodeCoverage]

    internal class FakePodcasterDataFactory 
    {
        private readonly FakeRepositoriesFactory fakeRepositoriesFactory;

        internal FakePodcasterDataFactory(FakeRepositoriesFactory fakeRepositoriesFactory)
        {
            this.fakeRepositoriesFactory = fakeRepositoriesFactory;
        }

        internal IMock<IPodcasterDataEF> GetPodcasterData()
        {
            var fakeData = new Mock<IPodcasterDataEF>();

            var fakePodcastRepo = this.fakeRepositoriesFactory.GetPodcastRepository();
            fakeData.Setup(x => x.Podcasts).Returns(fakePodcastRepo.Object);

            return fakeData;
        }
    }
}
