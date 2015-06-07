using sabio_hackforla.Constants;
using sabio_hackforla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace sabio_hackforla.Service
{
    public class PlantService
    {
        public Plant GetPlantFromJustVisual(string imagePath)
        {
            Plant plant = null;
            WebClient client = new WebClient();
            client.BaseAddress = "http://garden.vsapi01.com/api-search/";
            return plant;
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