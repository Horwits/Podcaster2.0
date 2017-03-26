using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Podcaster.Models;
using Podcaster.Web.Models.Podcast;

namespace Podcaster.Web.Models
{
    public class TopTenPodcastsViewModel
    {
       [Display(Name = "Top ten podcasts")]
        public IEnumerable<PodcastDetailsViewModel> TopTen
        {
            get
            {
                var list = new List<PodcastDetailsViewModel>();

                for (int i = 0; i < 10; i++)
                {
                    list.Add(new PodcastDetailsViewModel
                                   {
                                       Title = "The Joe Rogan Experience - Joe Rogan",
                                       Author = "Joe Rogan",
                                       ImageUrl =
                                           "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                                       IsExplicit = true,
                                       Pricing = 0m,
                                       FeedUrl = "http://joeroganexp.joerogan.libsynpro.com/rss"
                                   });
                }

                return list;
            }
        }

        /*public Podcast PodcastDetails { get; set; }*/
    }
}