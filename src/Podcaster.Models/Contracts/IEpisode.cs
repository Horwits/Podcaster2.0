using System;

namespace Podcaster.Models.Contracts
{
    public interface IEpisode
    {
        DateTime Date { get; set; }

        string Description { get; set; }

        Guid EpisodeId { get; set; }

        string ImageUrl { get; set; }

        PodcastEntity Podcast { get; set; }

        Guid PodcastId { get; set; }

        string Title { get; set; }
    }
}