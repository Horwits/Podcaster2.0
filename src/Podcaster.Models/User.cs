using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcaster.Models
{
    [ExcludeFromCodeCoverage]
    public class User
    {
        public User()
        {
            this.Subscriptions = new HashSet<PodcastEntity>();
        }

        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        private ICollection<PodcastEntity> Subscriptions { get; set; }
    }
}
