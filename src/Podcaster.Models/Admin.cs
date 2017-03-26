using System;
using System.Diagnostics.CodeAnalysis;

namespace Podcaster.Models
{
    [ExcludeFromCodeCoverage]
    public class Admin
    {
        public Admin()
        {
        }

        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
