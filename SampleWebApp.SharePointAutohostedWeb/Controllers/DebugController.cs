using System.Web.Mvc;
using SampleWebApp.Components;
using SampleWebApp.Components.Attributes;

namespace SampleWebApp.Controllers
{
    [RequiresAuthentication]
    [SelectedNavigation("debug")]
    public class DebugController : Controller
    {
        [SharePointContextFilter]
        public ActionResult Index()
        {
            ViewBag.Title = "Debug";
            return View();
        }
    }
}