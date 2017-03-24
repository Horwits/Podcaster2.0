using System.Collections.Generic;

namespace Podcaster.Models
{
    public class Podcast
    {
        public string AuthorName { get; set; }

        public ICollection<string> Categories { get; set; }

        public string Copyright { get; set; }

        public string Description { get; set; }

        public string HomepageUrl { get; set; }

        public string ImageUrl { get; set; }

        public bool IsExplicit { get; set; }

        public string Language { get; set; }

        public decimal Pricing { get; set; }

        public string Title { get; set; }
    }
}