using sabio_hackforla.Constants;
using sabio_hackforla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sabio_hackforla.Data.RecommendDTO
{
    public class GroundCoverDTO : PlantAdvancedModel
    {
        private PlantAdvancedModel _plant;

        public PlantAdvancedModel GetEuphorbia()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "Euphorbia Myrsinites";
            _plant.LatinName = "Euphorbia myrsinites";
            _plant.Height = 0.5;
            _plant.Width = 1;
            _plant.FlowerSeason = string.Join(",", new string[] { SeasonType.Spring, SeasonType.Summer, SeasonType.Fall });
            _plant.FlowerColor = "chrome yellow";
            _plant.Texture = FoliageTextureType.Medium;
            _plant.FoliageColor = "gray-green";
            _plant.HardinessRangeLow = 0;
            _plant.HardinessRangeHigh = 10;
            _plant.Growth = GrowthType.Mod;
            _plant.WaterNeed = WaterNeedType.Low;
            _plant.Evergreen = true;
            _plant.ImagePath = "/img/euphorbia-myrsinites.jpg";
            _plant.PlantType = PlantType.GroundCover;
            _plant.PlantDescription = "Euphorbia myrsinites is even tough than E. rigida, being hardy in all USDA zones to less than -10F. The leaf arrangements on the stems form blue-gray spirals.  Overall, this plant is only 6\"high x 12\" wide. Remove old, yellowing stems after flowering. E. myrsinites may be short-lived in warm winter areas. Native to southern Europe.";
            return _plant;
        }

        public PlantAdvancedModel GetOenothera()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "Mexican Evening Primrose";
            _plant.LatinName = "Oenothera berlandieri";
            _plant.Height = 1;
            _plant.Width = 3;
            _plant.FlowerSeason = string.Join(",", new string[] { SeasonType.Spring, SeasonType.Summer, SeasonType.Fall });
            _plant.FlowerColor = "pink";
            _plant.Texture = FoliageTextureType.Fine;
            _plant.FoliageColor = "green";
            _plant.HardinessRangeLow = 0;
            _plant.HardinessRangeHigh = 24;
            _plant.Growth = GrowthType.Fast;
            _plant.WaterNeed = WaterNeedType.Mod;
            _plant.Evergreen = true;
            _plant.ImagePath = "/img/oenothera-berlandieri.jpg";
            _plant.PlantType = PlantType.GroundCover;
            _plant.PlantDescription = "This hardy groundcover spreads by root sprouts, making it good for erosion control once established. It is native to East Texas and Mexico. Pink flowers cover the plant in spring. Sporadic flowering continues through the warm season.  It needs adequate water to remain attractive.";
            return _plant;
        }

        public PlantAdvancedModel GetZauschneria()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "California Fuchsia, Hummingbird Trumpet";
            _plant.LatinName = "Zauschneria californica subspecies latifolia";
            _plant.Height = 1;
            _plant.Width = 4;
            _plant.FlowerSeason = string.Join(",", new string[] { SeasonType.Summer, SeasonType.Fall });
            _plant.FlowerColor = "red-orange";
            _plant.Texture = FoliageTextureType.Medium;
            _plant.FoliageColor = "sage-green";
            _plant.HardinessRangeLow = 0;
            _plant.HardinessRangeHigh = 32;
            _plant.Growth = GrowthType.Mod;
            _plant.WaterNeed = WaterNeedType.Mod;
            _plant.Evergreen = false;
            _plant.ImagePath = "/img/zauschneria-californica.jpg";
            _plant.PlantType = PlantType.GroundCover;
            _plant.PlantDescription = "Look for this Arizona and California native in riparian areas with year-round water.  Plants may be scraggly or lush depending on water availability. Tubular, fluorescent-orange flowers persist until frost.";
            return _plant;
        }
    }
}