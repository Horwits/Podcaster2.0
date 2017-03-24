using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Podcaster.Models;

namespace Podcaster.Web.Models
{
    public class TopTenPodcastsViewModel
    {
        public IEnumerable<Podcast> TopTen
        {
            get
            {
                return new List<Podcast>
                           {
                               new Podcast
                                   {
                                       Title = "The Joe Rogan Experience - Joe Rogan",
                                       AuthorName = "Joe Rogan",
                                       ImageUrl = "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                                       IsExplicit = true,
                                      Pricing = 0m
                                   },
                                new Podcast
                                   {
                                       Title = "The Joe Rogan Experience - Joe Rogan",
                                       AuthorName = "Joe Rogan",
                                       ImageUrl = "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                                       IsExplicit = true,
                                      Pricing = 0m
                                   },
                                 new Podcast
                                   {
                                       Title = "The Joe Rogan Experience - Joe Rogan",
                                       AuthorName = "Joe Rogan",
                                       ImageUrl = "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                                       IsExplicit = true,
                                      Pricing = 0m
                                   },
                                  new Podcast
                                   {
                                       Title = "The Joe Rogan Experience - Joe Rogan",
                                       AuthorName = "Joe Rogan",
                                       ImageUrl = "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                                       IsExplicit = true,
                                      Pricing = 0m
                                   },
                                   new Podcast
                                   {
                                       Title = "The Joe Rogan Experience - Joe Rogan",
                                       AuthorName = "Joe Rogan",
                                       ImageUrl = "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                                       IsExplicit = true,
                                      Pricing = 0m
                                   },
                                    new Podcast
                                   {
                                       Title = "The Joe Rogan Experience - Joe Rogan",
                                       AuthorName = "Joe Rogan",
                                       ImageUrl = "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                                       IsExplicit = true,
                                      Pricing = 0m
                                   },
                                     new Podcast
                                   {
                                       Title = "The Joe Rogan Experience - Joe Rogan",
                                       AuthorName = "Joe Rogan",
                                       ImageUrl = "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                                       IsExplicit = true,
                                      Pricing = 0m
                                   },
                                      new Podcast
                                   {
                                       Title = "The Joe Rogan Experience - Joe Rogan",
                                       AuthorName = "Joe Rogan",
                                       ImageUrl = "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                                       IsExplicit = true,
                                      Pricing = 0m
                                   },
                                       new Podcast
                                   {
                                       Title = "The Joe Rogan Experience - Joe Rogan",
                                       AuthorName = "Joe Rogan",
                                       ImageUrl = "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                                       IsExplicit = true,
                                      Pricing = 0m
                                   },
                                        new Podcast
                                   {
                                       Title = "The Joe Rogan Experience - Joe Rogan",
                                       AuthorName = "Joe Rogan",
                                       ImageUrl = "http://is3.mzstatic.com/image/thumb/Podcasts122/v4/8c/47/f0/8c47f063-b593-ce2e-1478-68adac8114f5/mza_2606999114440466430.jpg/170x170bb-85.jpg",
                                       IsExplicit = true,
                                      Pricing = 0m
                                   }
                           };
            }
        }

        /*public Podcast PodcastDetails { get; set; }*/
    }
}