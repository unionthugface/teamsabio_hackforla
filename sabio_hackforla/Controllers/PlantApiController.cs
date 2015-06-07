using Newtonsoft.Json.Linq;
using sabio_hackforla.Constants;
using sabio_hackforla.Models;
using sabio_hackforla.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace sabio_hackforla.Controllers
{
    [RoutePrefix("plant")]
    public class PlantApiController : ApiController
    {
        private PlantService _plantService;

        public PlantApiController()
        {
            _plantService = new PlantService();
        }

        [Route("upload"), HttpPost]
        public HttpResponseMessage UploadImage()
        {
            var httpRequest = HttpContext.Current.Request;
            var serverPath = System.Web.Hosting.HostingEnvironment.MapPath("~/Content/img/upload/");
            string postedFilePath = null;
            //upload image to wherever we're uploading images to
            foreach (string file in httpRequest.Files)
            {
                HttpPostedFile postedFile = httpRequest.Files[file];

                postedFilePath = postedFile.FileName;

                postedFile.SaveAs(serverPath + postedFilePath);
                Console.WriteLine("Upload 1 completed");
            }
            string imagePath = String.Format("http://{0}{1}{2}", HttpContext.Current.Request.Url.Host, "/Content/img/upload/", postedFilePath);
            //calls third-party api
            HttpResponseMessage resp = null;
            try
            {
                JToken plants = _plantService.GetPlantFromJustVisual(imagePath);
                resp = Request.CreateResponse(HttpStatusCode.OK, plants);
            }
            catch (Exception ex)
            {
                resp = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

            return resp;
        }

        [Route("jvquery"), HttpGet]
        public HttpResponseMessage GetJustVisualResultsByImage(string imagePath = "http://c2.staticflickr.com/4/3467/3895548557_5ff7e67db2_n.jpg")
        {
            //calls third-party api
            HttpResponseMessage resp = null;
            try
            {
                JToken plants = _plantService.GetPlantFromJustVisual(imagePath);
                resp = Request.CreateResponse(HttpStatusCode.OK, plants);
            }
            catch (Exception ex)
            {
                resp = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

            return resp;
        }

        [Route("getplant"), HttpPost]
        public HttpResponseMessage GetPlantById(Guid plantId) 
        {
            //when you select that a plant is a match, this returns info on the plant
            HttpResponseMessage resp = null;

            try
            {
                //Plant plant = _plantService.GetPlantById(plantId);
                //resp = Request.CreateResponse(HttpStatusCode.OK, plant);
            }
            catch (Exception ex)
            {
                resp = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

            return resp;
        }

        [Route("add"), HttpPost]
        public HttpResponseMessage AddPlantToGarden(Guid plantId)
        {
            HttpResponseMessage resp = null;
            try
            {
                //make relationship between plant and userid

                //collect and add geocode data to plant
            }
            catch (Exception ex)
            {
                resp = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }            

            return resp;
        }

        [Route("recommend"), HttpGet]
        public HttpResponseMessage GetLowWaterOptions(Guid? plantId = null, string plantType = null) 
        {
            //send in a plant id and get low water options back
            HttpResponseMessage resp = null;

            try
            {
                if (plantId != null && !string.IsNullOrEmpty(plantType))
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "This method cannot accept two parameters. Please send one or the other.");
                }

                IEnumerable<PlantAdvancedModel> plants = null;

                if (plantId != null && plantId.HasValue)
                {
                    Plant plant = _plantService.GetPlantById(plantId.Value);
                    plants = _plantService.GetAlternativePlantsByType(plant.PlantType);
                }
                
                if (string.IsNullOrEmpty(plantType))
                {
                    plants = _plantService.GetAllAlternativePlants();
                }
                else
                {
                    switch(plantType)
                    {
                        case "groundcover":
                            plants = _plantService.GetAlternativePlantsByType(PlantType.GroundCover);
                            break;
                        case "shrub":
                            plants = _plantService.GetAlternativePlantsByType(PlantType.Shrub);
                            break;
                        case "tree":
                            plants = _plantService.GetAlternativePlantsByType(PlantType.Tree);
                            break;
                        case "deco":
                            plants = _plantService.GetAlternativePlantsByType(PlantType.Decorative);
                            break;
                        default: _plantService.GetAllAlternativePlants();
                            break;
                    }
                }

                resp = Request.CreateResponse(HttpStatusCode.OK, plants);
            }
            catch (Exception ex)
            {
                resp = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

            return resp;
        }

        [Route("garden"), HttpGet]
        public HttpResponseMessage GetGardenByGuid(Guid? gardenGuid = null) 
        { 
            //if gardenGuid is null, get user from context
            HttpResponseMessage resp = null;

            try
            {
                //List<Plant> plants = _plantService.GetGarden(gardenGuid);
                //resp = Request.CreateResponse(HttpStatusCode.OK, plants);
            }
            catch (Exception ex)
            {
                resp = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

            return resp;
        }

        [Route("plantsbyzip"), HttpGet]
        public HttpResponseMessage GetPlantsByZip(string zip)
        {
            //return geocode locations of plants in your area
            HttpResponseMessage resp = null;

            try
            {
                //List<Plant> plants = _plantService.GetPlantsByZip(zip);
                //resp = Request.CreateResponse(HttpStatusCode.OK, plants);
            }
            catch (Exception ex)
            {
                resp = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

            return resp;
        }

        [Route("nurseries"), HttpGet]
        public HttpResponseMessage GetNurseries(string zip = null)
        {
            //get nurseries from LA City Data
            HttpResponseMessage resp = null;

            try
            {
                List<GeoCode> nurseries = null;
                
                if (!string.IsNullOrEmpty(zip))
                {
                    nurseries = _plantService.GetNurseries(zip, null);
                }
                else
                {
                    //get user geolocation
                    //UserService uService = new UserService();
                    //GeoCode userLocation = uService.GetLocation();
                    //nurseries = _plantService.GetNurseries(null, userLocation);
                }

                if (nurseries != null)
                {
                    resp = Request.CreateResponse(HttpStatusCode.OK, nurseries);
                }
                else
                {
                    resp = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Nurseries could not be found");
                }
            }
            catch (Exception ex)
            {
                resp = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

            return resp;
        }
    }
}
