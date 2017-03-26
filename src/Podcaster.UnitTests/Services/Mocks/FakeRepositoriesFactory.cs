using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

using Moq;

using Podcaster.Data.Repositories.Contracts;
using Podcaster.Models;
using Podcaster.Models.Contracts;

namespace Podcaster.UnitTests.Services.Mocks
{
    internal class FakeRepositoriesFactory
    {
        private readonly FakePodcastEntityFactory fakePodcastEntityFactory;

        internal FakeRepositoriesFactory(FakePodcastEntityFactory fakePodcastEntityFactory)
        {
            this.fakePodcastEntityFactory = fakePodcastEntityFactory;
        }

        internal Mock<IRepository<PodcastEntity>> GetPodcastRepository()
        {
            var result = new Mock<IRepository<PodcastEntity>>(MockBehavior.Strict);
            result.Setup(x => x.Add(It.IsAny<PodcastEntity>()));
            result.Setup(x => x.Delete(It.IsAny<PodcastEntity>()));
            result.Setup(x => x.Update(It.IsAny<PodcastEntity>()));

            var all = this.GetListOfPodcasts();
            PodcastEntity podcastEntity = this.fakePodcastEntityFactory.GetPodcastEntity();

            result.Setup(x => x.All()).Returns(all.AsQueryable);

            result.Setup(x => x.GetById(It.IsAny<object>())).Returns(podcastEntity);
            result.Setup(x => x.GetByName(It.IsAny<string>())).Returns(podcastEntity);
            return result;
        }

        internal ICollection<PodcastEntity> GetListOfPodcasts()
        {
            PodcastEntity podcastEntity = this.fakePodcastEntityFactory.GetPodcastEntity();
            ICollection<PodcastEntity> all = new List<PodcastEntity>();
            all.Add(podcastEntity);
            all.Add(podcastEntity);
            all.Add(podcastEntity);
            return all;
        }
    }
}