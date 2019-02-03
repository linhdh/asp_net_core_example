using Microsoft.AspNetCore.Mvc;

namespace MyProject2.Web.Controllers
{
    public class HomeController : MyProject2ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}