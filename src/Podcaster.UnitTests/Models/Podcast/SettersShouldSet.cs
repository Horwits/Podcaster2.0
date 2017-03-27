using System;
using System.Collections.Generic;

using NUnit.Framework;

using Podcaster.Models;

namespace Podcaster.UnitTests.Models.Podcast
{
    [TestFixture]
    public class SettersShouldSet
    {
        [Test]
        public void Setters_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var idVal = new Guid();
            var categories = new List<string>() { "Comedy" };
            var sut = new PodcastEntity
                          {
                              AuthorName = "Joe Rogan",
                              Copyright = "Talking Monkey Productions",
                              Description = "Conduit to the Gaian Mind",
                              FeedUrl = "http://joeroganexp.joerogan.libsynpro.com/rss",
                              ImageUrl =
                                  "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                              Language = "English",
                              Categories = categories,
                              Id = idVal,
                              Pricing = 0m,
                              Title = "The Joe Rogan Experience - Joe Rogan",
                              IsExplicit = true,
                          };

            // Act & Assert
            Assert.AreSame("Joe Rogan", sut.AuthorName);
            Assert.AreSame("Talking Monkey Productions", sut.Copyright);
            Assert.AreSame("Conduit to the Gaian Mind", sut.Description);
            Assert.AreSame("http://joeroganexp.joerogan.libsynpro.com/rss", sut.FeedUrl);
            Assert.AreSame(
                "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                sut.ImageUrl);
            Assert.AreSame("English", sut.Language);
            Assert.AreSame("The Joe Rogan Experience - Joe Rogan", sut.Title);
            Assert.AreSame(categories, sut.Categories);
            Assert.AreEqual(idVal, sut.Id);
            Assert.AreEqual(0m, sut.Pricing);
            Assert.AreEqual(true, sut.IsExplicit);
        }
    }
}