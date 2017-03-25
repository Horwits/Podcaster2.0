using System.Collections.Generic;
using System.Web.Mvc;

namespace Podcaster.Web.Models.Manage
{
    public class ConfigureTwoFactorViewModel
    {
        public ICollection<SelectListItem> Providers { get; set; }

        public string SelectedProvider { get; set; }
    }
}