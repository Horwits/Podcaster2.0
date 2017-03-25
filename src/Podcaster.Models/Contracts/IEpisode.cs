using System;

namespace Podcaster.Models.Contracts
{
    public interface IEpisode
    {
        string Description { get; set; }

        Guid EpisodeId { get; set; }

        string ImageUrl { get; set; }

        string Title { get; set; }

        DateTime Date { get; set; }

        Guid PodcastId { get; set; }

        Podcast Podcast { get; set; }
    }
}