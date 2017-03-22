using System;

using Microsoft.AspNet.Identity;

namespace Podcaster.Models.Models
{
    public class Role : IRole<Guid>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}