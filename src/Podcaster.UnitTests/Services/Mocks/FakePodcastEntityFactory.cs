using System;

using Moq;

using Podcaster.Models;
using Podcaster.Models.Contracts;

namespace Podcaster.UnitTests.Services.Mocks
{
    internal class FakePodcastEntityFactory
    {
        internal IMock<IPodcastEntity> GetPodcastEntity()
        {
            var mockEntity = new Mock<IPodcastEntity>();
            mockEntity.SetupProperty(x => x.AuthorName, "Joe Rogan");
            mockEntity.SetupProperty(x => x.Copyright, "Talking Monkey Productions");
            mockEntity.SetupProperty(x => x.Description, "Conduit to the Gaian Mind");
            mockEntity.SetupProperty(x => x.FeedUrl, "http://joeroganexp.joerogan.libsynpro.com/rss");
            mockEntity.SetupProperty(x => x.ImageUrl, "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg");
            mockEntity.SetupProperty(x => x.Language, "English");
            mockEntity.SetupProperty(x => x.PodcastId, new Guid());
            mockEntity.SetupProperty(x => x.Pricing, 0m);
            mockEntity.SetupProperty(x => x.Title, "The Joe Rogan Experience - Joe Rogan");
            mockEntity.SetupProperty(x => x.IsExplicit, true);
            mockEntity.SetupProperty(x => x.Pricing, 0m);

            return mockEntity;
        }
    }
}