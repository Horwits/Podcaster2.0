using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Podcaster.Models.Contracts;

namespace Podcaster.Models
{
    public class PodcastEntity : IPodcastEntity
    {
        public PodcastEntity()
        {
            this.Subscribers = new HashSet<ApplicationUser>();
        }

        [DisplayName("Author")]
        [StringLength(30)]
        public string AuthorName { get; set; }

        public ICollection<string> Categories { get; set; }

        public string Copyright { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [DisplayName("Feed")]
        [Required]
        public string FeedUrl { get; set; }

        [Key]
        public Guid Id { get; set; }

        public string ImageUrl { get; set; }

        [DisplayName("Explicit content")]
        public bool IsExplicit { get; set; }

        [StringLength(15)]
        public string Language { get; set; }

        [DisplayName("Price")]
        [Required]
        public decimal Pricing { get; set; }

        public virtual ICollection<ApplicationUser> Subscribers { get; set; }

        [StringLength(50)]
        public string Title { get; set; }
    }
}