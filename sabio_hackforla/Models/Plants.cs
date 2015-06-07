﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sabio_hackforla.Models
{
    public class Plant
    {

        public string GroundCover { get; set; }

        public string Shrub { get; set; }

        public string Tree { get; set; }

        public string Decorative { get; set; }

        public int GeoCode { get; set; }

        public string PlantName { get; set; }

        public string PlantDescription { get; set; }

        public string SoilType { get; set; }

    }
}