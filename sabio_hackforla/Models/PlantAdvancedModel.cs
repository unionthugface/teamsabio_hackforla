using sabio_hackforla.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sabio_hackforla.Models
{
    public class PlantAdvancedModel : Plant
    {
        public string LatinName { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public string FlowerSeason { get; set; }

        public string FlowerColor { get; set; }

        public FoliageTextureType Texture { get; set; }

        public string FoliageColor { get; set; }

        public string Color { get; set; }

        public int HardinessRangeLow { get; set; }

        public int HardinessRangeHigh { get; set; }

        public GrowthType Growth { get; set; }

        public bool Evergreen { get; set; }

    }
}