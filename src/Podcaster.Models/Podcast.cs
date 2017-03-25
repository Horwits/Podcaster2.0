using System;
using System.Collections.Generic;

using Podcaster.Models.Contracts;

namespace Podcaster.Models
{
    public class Podcast : IPodcast
    {
        public Podcast()
        {
            this.Episodes = new HashSet<Episode>();
            this.Subscribers = new HashSet<ApplicationUser>();
        }

        public Guid PodcastId { get; set; }

        public string AuthorName { get; set; }

        public virtual ICollection<string> Categories { get; set; }

        public string Copyright { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool IsExplicit { get; set; }

        public string Language { get; set; }

        public decimal Pricing { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Episode> Episodes { get; set; }

        public virtual ICollection<ApplicationUser> Subscribers { get; set; }
    }
}