using sabio_hackforla.Models;
using sabio_hackforla.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sabio_hackforla.Controllers
{
    public class GardenController : Controller
    {
        // GET: Garden
        public ActionResult Index()
        {
            return View("MyGarden");
        }


        // GET: Recommendations
        public ActionResult List()
        {
            Guid id = new Guid();
            PlantService ps = new PlantService();
            PlantAdvancedModel pam = ps.GetPlantById(id);
            ViewBag.Image = pam.ImagePath;
            return View("Recommendations");
        }
    }
}