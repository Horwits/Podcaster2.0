using System;

using Podcaster.Models.Contracts;

namespace Podcaster.Models
{
    public class Episode : IEpisode
    {
        public string Description { get; set; }

        public Guid EpisodeId { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public Guid PodcastId { get; set; }

        public Podcast Podcast { get; set; }
    }
}