using System.Web.Mvc;

namespace Podcaster.Web.Areas.Error.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error/Error
        public ActionResult Index()
        {
            return this.View("Error");
        }
    }
}