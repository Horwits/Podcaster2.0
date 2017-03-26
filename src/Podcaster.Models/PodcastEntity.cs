using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Podcaster.Models.Contracts;

namespace Podcaster.Models
{
    public class PodcastEntity : IPodcastEntity
    {
        public PodcastEntity()
        {
            this.Subscribers = new HashSet<ApplicationUser>();
        }

        [Key]
        public Guid PodcastId { get; set; }

        [StringLength(15)]
        public string AuthorName { get; set; }

        public virtual ICollection<string> Categories { get; set; }

        public string Copyright { get; set; }

        [StringLength(15)]

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool IsExplicit { get; set; }

        [StringLength(15)]
        public string Language { get; set; }

        [Required]
        public decimal Pricing { get; set; }

        [Index]
        public string Title { get; set; }

        [Required]
        public string FeedUrl { get; set; }

        public virtual ICollection<ApplicationUser> Subscribers { get; set; }
    }
}