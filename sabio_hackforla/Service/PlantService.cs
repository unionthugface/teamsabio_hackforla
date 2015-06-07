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
    }
}