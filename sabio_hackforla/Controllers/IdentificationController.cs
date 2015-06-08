using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sabio_hackforla.Controllers
{
    public class IdentificationController : Controller
    {
        // GET: Matching
        public ActionResult Index(string url = "http://c2.staticflickr.com/4/3467/3895548557_5ff7e67db2_n.jpg")
        {
            ViewBag.imgurl = url;
            return View();
        }
    }
}