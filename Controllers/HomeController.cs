namespace JohannesQvarford.Website.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using JohannesQvarford.Website.Models;

    public class HomeController : Controller
    {
        public ActionResult Index(string language)
        {
            ViewBag.Projects = ProjectUtility.Projects;
            return View();
        }

        public ActionResult About(string language)
        {
            ViewBag.Projects = ProjectUtility.Projects;
            return View();
        }

        public ActionResult Cv(string language)
        {
            ViewBag.Projects = ProjectUtility.Projects;
            return View();
        }
    }
}