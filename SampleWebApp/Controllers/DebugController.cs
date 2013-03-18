using System.Web.Mvc;

namespace SampleWebApp.Controllers
{
    public class DebugController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Debug";
            ViewBag.SelectedNavClass = "debug";

            return View();
        }
    }
}