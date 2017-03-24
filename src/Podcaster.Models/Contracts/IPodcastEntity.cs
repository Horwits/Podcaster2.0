using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcaster.Models.Contracts
{
    public interface IPodcastEntity
    {
        string Title { get; set; }

        string Author { get; set; }

        string Description { get; set; }

        string ImageUrl { get; set; }

        string Rights { get; set; }

        decimal Price { get; set; }

    }
}
