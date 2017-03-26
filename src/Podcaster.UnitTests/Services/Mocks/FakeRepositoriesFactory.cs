using System;
using System.Collections.Generic;
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

        public FakeRepositoriesFactory(FakePodcastEntityFactory fakePodcastEntityFactory)
        {
            this.fakePodcastEntityFactory = fakePodcastEntityFactory;
        }

        internal Mock<IRepository<IPodcastEntity>> GetPodcastRepository()
        {
            var result = new Mock<IRepository<IPodcastEntity>>(MockBehavior.Strict);
            result.Setup(x => x.Add(It.IsAny<IPodcastEntity>()));
            result.Setup(x => x.Delete(It.IsAny<IPodcastEntity>()));
            result.Setup(x => x.Update(It.IsAny<IPodcastEntity>()));

            var all = this.GetListOfPodcasts();
            PodcastEntity podcastEntity = this.fakePodcastEntityFactory.GetPodcastEntity().Object;


            result.Setup(x => x.All()).Returns(all.AsQueryable);

            result.Setup(x => x.GetById(It.IsAny<object>())).Returns();
            result.Setup(x => x.GetByName(It.IsAny<string>())).Returns(this.fakePodcastEntityFactory.GetPodcastEntity().Object);
            return result;
        }

        private ICollection<IPodcastEntity> GetListOfPodcasts()
        {
            ICollection<IPodcastEntity> all = new List<IPodcastEntity>();
            all.Add(this.fakePodcastEntityFactory.GetPodcastEntity().Object);
            all.Add(this.fakePodcastEntityFactory.GetPodcastEntity().Object);
            all.Add(this.fakePodcastEntityFactory.GetPodcastEntity().Object);
            return all;
        }
    }
}