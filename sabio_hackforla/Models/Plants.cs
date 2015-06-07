using sabio_hackforla.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sabio_hackforla.Models
{
    public class Plant
    {

        public PlantType PlantType { get; set; }

        public int GeoCode { get; set; }

        public string PlantName { get; set; }

        public string PlantDescription { get; set; }

        public SoilType SoilType { get; set; }

        public WaterNeedType WaterNeed { get; set; }

        public List<GeoCode> Locations { get; set; }
    }
}