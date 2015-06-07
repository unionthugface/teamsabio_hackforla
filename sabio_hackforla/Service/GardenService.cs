using sabio_hackforla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace sabio_hackforla.Service
{
    public class GardenService
    {
        public static Garden GetGarden()
        {
            Garden myGarden = new Garden();
            myGarden.ListOfPlants = null;
            myGarden.Neighborhood = null;
            myGarden.Zipcode = 0;
            return myGarden;
        }
    }
}