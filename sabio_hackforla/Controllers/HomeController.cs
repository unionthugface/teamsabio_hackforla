using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sabio_hackforla.Controllers
{
    [RoutePrefix ("")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public  ActionResult Introduction()
        {
            return View();
        }

        public  ActionResult Recommendations()
        {
            return View();
        }

        public ActionResult MyGarden()
        {
            return View("~/Garden/MyGarden.cshtml");
        }

        public ActionResult PlantPic() {
            return View();
        }
    }
}
