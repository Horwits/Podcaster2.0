using System;

namespace Podcaster.Web.Models.Podcast
{
    public class PodcastDetailsViewModel
    {
        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public bool IsExplicit { get; set; }

        public DateTime LastUpdated { get; set; }

        public decimal Pricing { get; set; }

        public string Title { get; set; }

        public string FeedUrl { get; set; }
    }
}