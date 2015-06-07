using Newtonsoft.Json.Linq;
using sabio_hackforla.Constants;
using sabio_hackforla.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;

namespace sabio_hackforla.Service
{
    public class PlantService
    {
        private static String ApiKey = ConfigurationManager.AppSettings["ApiKey"];
        private static String ApiId = ConfigurationManager.AppSettings["ApiId"];
        private static String _BaseUrl = "http://garden.vsapi01.com/api-search/";
        

        public JToken GetPlantFromJustVisual(string imagePath)
        {
            WebClient client = new WebClient();
            
            string uri;

            uri = _BaseUrl + "by-url?url=" + imagePath + "&apiid=" + ApiId + "&apikey=" + ApiKey;
            string source = client.DownloadString(uri);

            JToken o = JToken.Parse(source);
            //jSON.deserialize<Plant>(source);

            return o;
        }

        public Plant GetPlantById(Guid plantId)
        {
            Plant plant = null;
            return plant;
        }

        public List<Plant> GetAlternativePlants(PlantType pType)
        {
            List<Plant> plants = null;
            return plants;
        }

        public List<Plant> GetGarden(Guid? gardenId)
        {
            List<Plant> plants = null;
            return plants;
        }

        public List<Plant> GetPlantsByZip(string zip)
        {
            List<Plant> plants = null;
            return plants;
        }

        public List<GeoCode> GetNurseries(string zip = null, GeoCode location = null)
        {
            List<GeoCode> nurseries = null;
            
            if (!string.IsNullOrEmpty(zip))
            {

            }
            if (location != null)
            {

            }

            return nurseries;
        }
    }
}