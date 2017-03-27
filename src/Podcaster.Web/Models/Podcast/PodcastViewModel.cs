using System.Collections.Generic;

using Podcaster.Models;

namespace Podcaster.Web.Models.Podcast
{
    public class PodcastViewModel
    {
        public PodcastEntity Podcast { get; set; }

        public IEnumerable<PodcastEntity> Podcasts { get; set; }

        /*public Guid Id { get; set; }

        public string Author { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Excplicit")]
        public bool IsExplicit { get; set; }

        /*[Display(Name = "Last updated")]
        public DateTime LastUpdated { get; set; }#1#

        public decimal Pricing { get; set; }

        public string Title { get; set; }

        [Display(Name = "Feed")]
        public string FeedUrl { get; set; }*/
    }
}