using System.Web.Mvc;
using SampleWebApp.Components;

namespace SampleWebApp.Controllers
{
    [RequiresAuthentication]
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