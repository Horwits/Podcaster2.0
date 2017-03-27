using System.Collections.Generic;

using NUnit.Framework;

using Podcaster.Models;
using Podcaster.UnitTests.Mocks;
using Podcaster.Web.Models.Podcast;

namespace Podcaster.UnitTests.WebClient.ViewModels.Podcast
{
    [TestFixture]
    public class PodcastDetailsViewModelTests
    {
        [Test]
        public void Setters_ShouldSetThePropeties()
        {
            // Arrange
            var podcastEntity = new FakePodcastEntityFactory().GetPodcastEntity();
            var podcasts = new List<PodcastEntity>() { podcastEntity };
            var sut = new PodcastViewModel { Podcast = podcastEntity, Podcasts = podcasts };

            // Act & Assert
            Assert.AreSame(podcasts, sut.Podcasts);
            Assert.AreSame(podcastEntity, sut.Podcast);
        }
    }
}