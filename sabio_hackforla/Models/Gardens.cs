using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sabio_hackforla.Models
{
    public class Garden
    {
        public String Neighborhood { get; set; }

        public int Zipcode { get; set; }

        public List<Plant> ListOfPlants { get; set; }
    }
}