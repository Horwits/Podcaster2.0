using System;
using System.Collections.Generic;

namespace Podcaster.Models.Contracts
{
    public interface IPodcastEntity
    {
        Guid PodcastId { get; set; }

        string AuthorName { get; set; }

        string Copyright { get; set; }

        string Description { get; set; }

        string ImageUrl { get; set; }

        decimal Pricing { get; set; }

        string Language { get; set; }

        string Title { get; set; }

        string FeedUrl { get; set; }

        bool IsExplicit { get; set; }
    }
}