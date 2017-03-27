using System;
using System.Linq;

using Bytes2you.Validation;

using Podcaster.Data.DataEF.Contracts;
using Podcaster.Models;
using Podcaster.Services.Podcast.Contracts;

namespace Podcaster.Services.Podcast
{
    public class PodcastService : IPodcastService
    {
        private readonly IPodcasterDataEF data;

        public PodcastService(IPodcasterDataEF data)
        {
            Guard.WhenArgument(data, nameof(data)).IsNull().Throw();

            this.data = data;
        }

        public void Add(PodcastEntity podcast)
        {
            Guard.WhenArgument(podcast, nameof(podcast)).IsNull().Throw();

            this.data.Podcasts.Add(podcast);
            this.data.SaveChanges();
        }

        public void Delete(PodcastEntity podcast)
        {
            Guard.WhenArgument(podcast, nameof(podcast)).IsNull().Throw();

            this.data.Podcasts.Delete(podcast);
            this.data.SaveChanges();
        }

        public PodcastEntity FindById(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException(nameof(id));
            }

            return this.data.Podcasts.GetById(id);
        }

        public PodcastEntity FindByTitle(string title)
        {
            Guard.WhenArgument(title, nameof(title)).IsNullOrEmpty().IsNullOrWhiteSpace().Throw();

            return this.data.Podcasts.All().FirstOrDefault(x => x.Title.Contains(title));
        }

        public void Update(PodcastEntity podcast)
        {
            Guard.WhenArgument(podcast, nameof(podcast)).IsNull().Throw();

            this.data.Podcasts.Update(podcast);
            this.data.SaveChanges();
        }
    }
}