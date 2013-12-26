using System.Web.Mvc;

namespace SampleWebApp.Components.Attributes
{
    public class SelectedNavigationAttribute : ActionFilterAttribute
    {
        public SelectedNavigationAttribute(string selectedNavClass)
        {
            SelectedNavClass = selectedNavClass;
        }

        public string SelectedNavClass { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewData["SelectedNavClass"] = SelectedNavClass;
        }
    }
}