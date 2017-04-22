namespace JohannesQvarford.Website.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Models;

    public class ProjectsController : Controller
    {
        public ActionResult GetProject(string title)
        {
            var viewName = RouteUtility.UrlSegmentToViewName(title);
            ViewBag.Projects = ProjectUtility.Projects;
            return View(viewName);
        }
    }
}