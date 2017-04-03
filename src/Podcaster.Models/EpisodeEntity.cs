using System;
using System.Collections.Generic;

using Bytes2you.Validation;

using Podcaster.Common.Validators;

namespace Podcaster.Models
{
    public class EpisodeEntity
    {
        private readonly IEpisodeEntitiesValidator validator;

        private string title;

        private string summary;

        private IEnumerable<string> mediaUrls;

        private DateTimeOffset publishDate;

        public EpisodeEntity(string title, DateTimeOffset publishDate, string summary, IEnumerable<string> mediaUrls, IEpisodeEntitiesValidator validator)
            : this(title, publishDate, summary, mediaUrls)

        {
            this.validator = validator;
        }

        public EpisodeEntity(string title, DateTimeOffset publishDate, string summary, IEnumerable<string> mediaUrls)
        {
            this.title = title;
            this.publishDate = publishDate;
            this.summary = summary;
            this.mediaUrls = mediaUrls;
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                this.validator.ValidateNotProvidedStringMember(value);
                this.title = value;
            }
        }

        public DateTimeOffset PublishDate
        {
            get
            {
                return this.publishDate;
            }

            private set
            {
                Guard.WhenArgument(this.publishDate, nameof(this.publishDate)).IsEqual(default(DateTimeOffset)).Throw();
                this.publishDate = value;
            }
        }

        public string Summary
        {
            get
            {
                return this.summary;
            }

            private set
            {
                this.validator.ValidateNotProvidedStringMember(value);
                this.summary = value;
            }
        }

        public IEnumerable<string> MediaUrls
        {
            get
            {
                return this.mediaUrls;
            }

            private set
            {
                Guard.WhenArgument(this.mediaUrls, nameof(this.mediaUrls)).IsNull().Throw();
                this.mediaUrls = value;
            }
        }

        public override string ToString()
        {
            return this.Title + Environment.NewLine + this.PublishDate.ToString() + Environment.NewLine + this.Summary
                   + Environment.NewLine + string.Join(" ", this.MediaUrls);
        }
    }
}
