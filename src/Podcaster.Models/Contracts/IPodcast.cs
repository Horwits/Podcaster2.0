using System.Collections.Generic;

namespace Podcaster.Models.Contracts
{
    public interface IPodcast
    {
        string AuthorName { get; set; }

        string Copyright { get; set; }

        string Description { get; set; }

        string ImageUrl { get; set; }

        decimal Pricing { get; set; }

        string Language { get; set; }

        string Title { get; set; }

        ICollection<Episode> Episodes { get; set; }
    }
}