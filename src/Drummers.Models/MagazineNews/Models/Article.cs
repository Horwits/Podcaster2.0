using System;
using System.ComponentModel.DataAnnotations;

using Drummers.Models.Contracts;

namespace Drummers.Models.MagazineNews.Models
{
    public class Article : IArticle
    {
        public Guid Id { get; set; }

        [Required]
        public string Provider { get; set; }

        [Required]
        public string Url { get; set; }


        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(400)]
        public string Description { get; set; }
    }
}
