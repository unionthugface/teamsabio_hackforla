﻿using System;
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
        [Route("upload"), HttpPost]
        public HttpResponseMessage UploadImage(string imagePath)
        {
            //calls third-party api
            HttpResponseMessage resp = null;

            return resp;
        }

        [Route("getplant"), HttpPost]
        public HttpResponseMessage GetPlantById(Guid plantId) 
        {
            //when you select that a plant is a match, this returns info on the plant
            HttpResponseMessage resp = null;

            return resp;
        }

        [Route("add"), HttpPost]
        public HttpResponseMessage AddPlantToGarden(Guid plantId)
        {
            //make relationship between plant and userid

            //collect and add geocode data to plant
            HttpResponseMessage resp = null;

            return resp;
        }

        [Route("recommend"), HttpGet]
        public HttpResponseMessage GetLowWaterOptions(Guid plantId) 
        {
            //send in a plant id and get low water options back
            HttpResponseMessage resp = null;

            return resp;
        }

        [Route("mygarden"), HttpGet]
        public HttpResponseMessage GetMyGarden() 
        { 
            //get current user and return their garden of plants
            HttpResponseMessage resp = null;

            return resp;
        }

        [Route("plantsbyzip"), HttpGet]
        public HttpResponseMessage GetPlantsByZip(string zip)
        {
            //return geocode locations of plants in your area
            HttpResponseMessage resp = null;

            return resp;
        }

        [Route("nurseries"), HttpGet]
        public HttpResponseMessage GetNurseries(string zip)
        {
            //get nurseries from LA City Data
            HttpResponseMessage resp = null;

            return resp;
        }
    }
}
