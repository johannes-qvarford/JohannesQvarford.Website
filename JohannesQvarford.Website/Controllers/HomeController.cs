namespace JohannesQvarford.Website.Controllers
{
    using System.Web.Mvc;

    using JohannesQvarford.Website.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Projects = ProjectUtility.Projects;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Projects = ProjectUtility.Projects;
            return View();
        }
    }
}