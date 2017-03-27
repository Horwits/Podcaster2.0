using System.ComponentModel;

using Podcaster.Models;

namespace Podcaster.Web.Models.Search
{
    public class SearchViewModel
    {
        public PodcastEntity Podcast { get; set; }

        [DisplayName("Name")]
        public string SearchTitle { get; set; }
    }
}