using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcaster.Models
{
    public class User
    {
        public User()
        {
            this.Subscriptions = new HashSet<Podcast>();
        }

        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        private ICollection<Podcast> Subscriptions { get; set; }
    }
}
