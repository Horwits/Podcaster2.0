using System;

namespace Podcaster.Models.Contracts
{
    public interface IPodcastEntity
    {
        string AuthorName { get; set; }

        string Copyright { get; set; }

        string Description { get; set; }

        string FeedUrl { get; set; }

        Guid Id { get; set; }

        string ImageUrl { get; set; }

        bool IsExplicit { get; set; }

        string Language { get; set; }

        decimal Pricing { get; set; }

        string Title { get; set; }
    }
}