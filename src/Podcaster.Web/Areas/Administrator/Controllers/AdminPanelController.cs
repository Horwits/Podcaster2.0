using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace Podcaster.Web.Areas.Administrator.Controllers
{
    [ExcludeFromCodeCoverage]
    public class AdminPanelController : Controller
    {
        // GET: Administrator/AdminPanel
        public ActionResult Index()
        {
            return this.View();
        }
    }
}