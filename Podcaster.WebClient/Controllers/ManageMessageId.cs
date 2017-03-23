using System.Web.Mvc;

namespace Podcaster.WebClient.Controllers
{
    public partial class ManageController : Controller
    {
        public enum ManageMessageId
        {
            AddPhoneSuccess,

            ChangePasswordSuccess,

            SetTwoFactorSuccess,

            SetPasswordSuccess,

            RemoveLoginSuccess,

            RemovePhoneSuccess,

            Error
        }
    }
}