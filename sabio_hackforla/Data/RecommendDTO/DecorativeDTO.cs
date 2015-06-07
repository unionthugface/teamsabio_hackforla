using sabio_hackforla.Constants;
using sabio_hackforla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sabio_hackforla.Data.RecommendDTO
{
    public class DecorativeDTO
    {
        private PlantAdvancedModel _plant;

        public PlantAdvancedModel GetEchinocactus()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "Golden Barrel Cactus";
            _plant.LatinName = "Echinocactus grusonii";
            _plant.Height = 2;
            _plant.Width = 4;
            _plant.FlowerSeason = SeasonType.Spring;
            _plant.FlowerColor = "yellow";
            _plant.Texture = FoliageTextureType.Coarse;
            _plant.FoliageColor = "gold";
            _plant.HardinessRangeLow = 0;
            _plant.HardinessRangeHigh = 18;
            _plant.Growth = GrowthType.Slow;
            _plant.WaterNeed = WaterNeedType.Low;
            _plant.Evergreen = true;
            _plant.ImagePath = "/img/echinocactus-grusonii.jpg";
            _plant.PlantType = PlantType.Decorative;
            _plant.PlantDescription = "Beautiful golden spines make this cactus colorful year-round.  Native to southern Mexico, it prefers light shade, but can be acclimated to full sun.  Golden Barrel Cactus is most attractive in groupings and is suitable for use in large pots.  Water every two weeks in summer.";
            return _plant;
        }

        public PlantAdvancedModel GetLotus()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "Deer Vetch";
            _plant.LatinName = "Lotus rigidus";
            _plant.Height = 1;
            _plant.Width = 2;
            _plant.FlowerSeason = SeasonType.Spring;
            _plant.FlowerColor = "yellow";
            _plant.Texture = FoliageTextureType.Fine;
            _plant.FoliageColor = "green";
            _plant.HardinessRangeLow = 0;
            _plant.HardinessRangeHigh = 18;
            _plant.Growth = GrowthType.Mod;
            _plant.WaterNeed = WaterNeedType.Low;
            _plant.Evergreen = true;
            _plant.ImagePath = "/img/lotus-rigidus.jpg";
            _plant.PlantType = PlantType.Decorative;
            _plant.PlantDescription = "This native to the Arizona Upland and chaparral does not do well in clay soils. Deer Vetch bears small, yellow, pea-shaped flowers in spring. The open blue-green foliage provides interesting texture making Deer Vetch a good contrast for plants with gray foliage.";
            return _plant;
        }

        public PlantAdvancedModel GetOpuntia()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "Buckhorn Cholla";
            _plant.LatinName = "Opuntia acanthocarpa";
            _plant.Height = 5;
            _plant.Width = 5;
            _plant.FlowerSeason = SeasonType.Spring;
            _plant.FlowerColor = "varies";
            _plant.Texture = FoliageTextureType.Coarse;
            _plant.FoliageColor = "green";
            _plant.HardinessRangeLow = 19;
            _plant.HardinessRangeHigh = 24;
            _plant.Growth = GrowthType.Mod;
            _plant.WaterNeed = WaterNeedType.Low;
            _plant.Evergreen = true;
            _plant.ImagePath = "/img/opuntia-acanthocarpa.jpg";
            _plant.PlantType = PlantType.Decorative;
            _plant.PlantDescription = "Buckhorn Cholla covers large areas of the Sonoran Desert.  It is similar to Staghorn Cholla from the southern part of Arizona.  Flower color is variable--yellow, orange, or rose. Flower buds are harvested by Native Americans and dried for food.";
            return _plant;
        }

    }
}