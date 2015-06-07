using sabio_hackforla.Constants;
using sabio_hackforla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sabio_hackforla.Data.RecommendDTO
{
    public class ShrubDTO : PlantAdvancedModel
    {
        private PlantAdvancedModel _plant;

        public PlantAdvancedModel GetCaesalpinia()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "Desert Bird of Paradise";
            _plant.LatinName = "Caesalpinia gilliesii";
            _plant.Height = 5;
            _plant.Width = 5;
            _plant.FlowerSeason = string.Join(",", new { SeasonType.Summer, SeasonType.Fall });
            _plant.FlowerColor = "yellow";
            _plant.Texture = FoliageTextureType.Fine;
            _plant.FoliageColor = "green";
            _plant.HardinessRangeLow = 5;
            _plant.HardinessRangeHigh = 10;
            _plant.Growth = GrowthType.Mod;
            _plant.WaterNeed = WaterNeedType.Low;
            _plant.Evergreen = false;
            _plant.ImagePath = "~/img/caesalpinia-gilliesii.jpg";
            _plant.PlantType = PlantType.Shrub;
            _plant.PlantDescription = "Desert Bird of Paradise has relatively sparse foliage.  Flowers are medium yellow with long red stamens.  Mature size varies from 5' x 5' to 8' x 8' depending on water availability.\r\n\r\nNative to Argentina, the Desert Bird of Paradise is extremely drought-tolerant and cold-hardy to 5-10F.";
            return _plant;
        }

        public PlantAdvancedModel GetFouquieria()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "Ocotillo";
            _plant.LatinName = "Fouquieria splendens";
            _plant.Height = 20;
            _plant.Width = 15;
            _plant.FlowerSeason = SeasonType.Spring;
            _plant.FlowerColor = "red-orange";
            _plant.Texture = FoliageTextureType.Fine;
            _plant.FoliageColor = "green";
            _plant.HardinessRangeLow = 0;
            _plant.HardinessRangeHigh = 5;
            _plant.Growth = GrowthType.Slow;
            _plant.WaterNeed = WaterNeedType.ModLow;
            _plant.Evergreen = false;
            _plant.ImagePath = "~/img/fouquieria-splendens.jpg";
            _plant.PlantType = PlantType.Shrub;
            _plant.PlantDescription = "Ocotillo is a shrub--not a cactus--native to the Sonoran and Chihuahuan Deserts up to 5,000'. The leaves drop during drought, thus dormancy depends on available soil moisture. Within three days after a monsoon the Ocotillo will be in full leaf. Its striking form and texture add interest to the landscape.";
            return _plant;
        }

        public PlantAdvancedModel GetLarrea()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "Creosote Bush";
            _plant.LatinName = "Larrea divaricata";
            _plant.Height = 8;
            _plant.Width = 6;
            _plant.FlowerSeason = string.Join(",", new { SeasonType.Spring, SeasonType.Summer, SeasonType.Fall }); 
            _plant.FlowerColor = "yellow";
            _plant.Texture = FoliageTextureType.Fine;
            _plant.FoliageColor = "olive";
            _plant.HardinessRangeLow = 0;
            _plant.HardinessRangeHigh = 5;
            _plant.Growth = GrowthType.Slow;
            _plant.WaterNeed = WaterNeedType.Low;
            _plant.Evergreen = true;
            _plant.ImagePath = "~/img/larrea-tridentata.jpg";
            _plant.PlantType = PlantType.Shrub;
            _plant.PlantDescription = "Small, bright, olive-green leaves contrast nicely with light-gray bark.  The branch structure is very graceful. Night lighitng will enhance the sculptural quality of this open shrub. Creosote is native to all deserts in the U.S.";
            return _plant;
        }
    }
}