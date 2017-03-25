﻿using System.Collections.Generic;

using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace Podcaster.Web.Models.Manage
{
    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }
}