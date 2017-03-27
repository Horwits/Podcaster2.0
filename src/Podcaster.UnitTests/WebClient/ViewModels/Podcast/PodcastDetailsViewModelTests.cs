using System;

using NUnit.Framework;

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
            string authorName = "Joe Rogan";
            string copyright = "Talking Monkey Productions";
            string description = "Conduit to the Gaian Mind";
            string feedUrl = "http://joeroganexp.joerogan.libsynpro.com/rss";
            string imageUrl =
                "http:is3.mzstati c.comthumbPodcasts122v4/8c/47f0/8c47f063b593ce2e-1478-68adac8114f5mza_2606999114440466430.jpg/170x170b85.jpg";
            string language = "English";
            var id = new Guid();
            decimal pricing = 0m;
            string title = "The Joe Rogan Experience - Joe Rogan";
            bool isExplicit = true;

            var sut = new PodcastDetailsViewModel
                          {
                              Author = authorName,
                              Description = description,
                              FeedUrl = feedUrl,
                              Id = id,
                              ImageUrl = imageUrl,
                              IsExplicit = isExplicit,
                              Pricing = pricing,
                              Title = title
                          };

            // Act & Assert
            Assert.AreSame(authorName, sut.Author);
            Assert.AreSame(description, sut.Description);
            Assert.AreSame(feedUrl, sut.FeedUrl);
            Assert.AreSame(imageUrl, sut.ImageUrl);
            Assert.AreSame(title, sut.Title);
            Assert.AreEqual(id, sut.Id);
            Assert.AreEqual(pricing, sut.Pricing);
            Assert.AreEqual(isExplicit, sut.IsExplicit);
        }
    }
}