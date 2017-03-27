using NUnit.Framework;

using Ploeh.AutoFixture;

using Podcaster.UnitTests.Base;
using Podcaster.UnitTests.Mocks;
using Podcaster.Web.Models.Search;

namespace Podcaster.UnitTests.WebClient.ViewModels.Search
{
    [TestFixture]
    public class SearchViewModelTests : BaseTestClass
    {
        [Test]
        public void TestMethod()
        {
            // Arrange
            var searchTerm = this.Fixture.Create<string>();
            var podcast = new FakePodcastEntityFactory().GetPodcastEntity();

            var sut = new SearchViewModel { SearchTitle = searchTerm, Podcast = podcast };

            // Act & Assert
            Assert.AreSame(podcast, sut.Podcast);
            Assert.AreSame(searchTerm, sut.SearchTitle);
        }
    }
}