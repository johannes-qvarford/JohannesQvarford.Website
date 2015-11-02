namespace JohannesQvarford.Website.Controllers
{
    using System.Web.Mvc;

    using Models;

    public class ProjectsController : Controller
    {
        public ActionResult GetProject(string title)
        {
            var viewName = RouteUtility.UrlSegmentToViewName(title);
            return View(viewName);
        }
    }
}