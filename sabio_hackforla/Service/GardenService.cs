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
        public static Garden GetGarden(int userId)
        {
            Garden myGarden = new Garden();
            myGarden.ListOfPlants = new List<Plant>();
            myGarden.ListOfPlants.Add(PlantService.getPlant());
            myGarden.ListOfPlants.Add(PlantService.getPlant());
            myGarden.ListOfPlants.Add(PlantService.getPlant());
            myGarden.ListOfPlants.Add(PlantService.getPlant());
            myGarden.ListOfPlants.Add(PlantService.getPlant());
            myGarden.ListOfPlants.Add(PlantService.getPlant());
            myGarden.Neighborhood = "Los Angeles";
            myGarden.Zipcode = 90034;
            return myGarden;
        }

        public static Garden UpdateGarden(Plant plant)
        {
            Garden myGarden = new Garden();
            myGarden.ListOfPlants = null;
            myGarden.Neighborhood = null;
            myGarden.Zipcode = 0;
            myGarden.ListOfPlants.Add(plant);
            return myGarden;
        }

        public static void InsertGarden(Garden garden)
        {

        }
    }
}