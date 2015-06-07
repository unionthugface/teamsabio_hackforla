using sabio_hackforla.Models;
using sabio_hackforla.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public HttpResponseMessage UploadImage(string imagePath)
        {
            //upload image to wherever we're uploading images to
            HttpResponseMessage resp = null;

            return resp;
        }

        [Route("jvquery"), HttpPost]
        public HttpResponseMessage GetJustVisualResultsByImage(string imagePath)
        {
            //calls third-party api
            HttpResponseMessage resp = null;
            try
            {
                //List<Plant> plants = _plantService.GetPlantFromJustVisual(imagePath);
                //resp = Request.CreateResponse(HttpStatusCode.OK, plants);
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
        public HttpResponseMessage GetLowWaterOptions(Guid plantId) 
        {
            //send in a plant id and get low water options back
            HttpResponseMessage resp = null;

            try
            {
                //Plant plant = _plantService.GetPlantById(plantId);
                //List<Plant> plants = _plantService.GetAlternativePlants(plant.PlantType);
                //resp = Request.CreateResponse(HttpStatusCode.OK, plants);
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
