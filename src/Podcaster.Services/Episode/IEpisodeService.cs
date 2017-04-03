using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;

using Bytes2you.Validation;

using Podcaster.Models;

namespace Podcaster.Services.Episode
{
    public interface IEpisodeService
    {
        IEnumerable<EpisodeEntity> GenerateLatestTenEpisodesFromRssFeed(string feedUrl);
    }

    public class EpisodeService : IEpisodeService
    {
        public IEnumerable<EpisodeEntity> GenerateLatestTenEpisodesFromRssFeed(string feedUrl)
        {
            Guard.WhenArgument(feedUrl, nameof(feedUrl)).IsNull().Throw();
            XmlReader reader = XmlReader.Create(feedUrl);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            var episodes = new List<EpisodeEntity>();

            if (feed == null)
            {
                throw new ArgumentException(nameof(feed));
            }
            else
            {
                for (var i = 0; i <= 10; i++)
                {
                    var item = feed.Items.ElementAt(i);
                    var title = item.Title?.Text;

                    var publishDate = item.PublishDate == default(DateTimeOffset)
                                           ? default(DateTimeOffset)
                                           : item.PublishDate.UtcDateTime;

                    var summary = item.Summary?.Text;

                    List<string> mediaLinks = new List<string>();
                    if (item.Links != null)
                    {
                        foreach (var link in item.Links)
                        {
                            mediaLinks.Add(link.Uri.AbsoluteUri); // listen -> if not null -> 1st link
                        }
                    }


                    var episode = new EpisodeEntity(title, publishDate, summary, mediaLinks);
                    episodes.Add(episode);
                }

                return episodes;
            }
        }
    }
}
