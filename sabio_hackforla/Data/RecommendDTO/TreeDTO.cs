using sabio_hackforla.Constants;
using sabio_hackforla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sabio_hackforla.Data.RecommendDTO
{
    public class TreeDTO : PlantAdvancedModel
    {
        private PlantAdvancedModel _plant;

        public PlantAdvancedModel GetBluePaloVerde()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "Blue Palo Verde";
            _plant.LatinName = "Cercidium floridum";
            _plant.Height = 30;
            _plant.Width = 30;
            _plant.FlowerSeason = SeasonType.Spring;
            _plant.FlowerColor = "yellow";
            _plant.Texture = FoliageTextureType.Fine;
            _plant.FoliageColor = "blue-green";
            _plant.HardinessRangeLow = 10;
            _plant.HardinessRangeHigh = 10;
            _plant.Growth = GrowthType.Fast;
            _plant.WaterNeed = WaterNeedType.ModLow;
            _plant.Evergreen = false;
            _plant.ImagePath = "~/img/cercidium-floridum.jpg";
            _plant.PlantType = PlantType.Tree;
            _plant.PlantDescription = "Blue Palo Verde has blue-green foliage and bark.  With age, the bark becomes rough and brown.  The foliage is slightly weeping compared to the stiff forms of other Ceridium.  Native to Arizona, Sonora and Baja California.  Blue Palo Verde flowers are bright yellow.  Mature size is approximately 30' x 30'.  Hardy to 10F.";
            return _plant;
        }

        public PlantAdvancedModel GetDesertWillow()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "Desert Willow";
            _plant.LatinName = "Chilopsis linearis";
            _plant.Height = 25;
            _plant.Width = 20;
            _plant.FlowerSeason = string.Join(",", SeasonType.Spring, SeasonType.Summer, SeasonType.Fall);
            _plant.FlowerColor = "lavender";
            _plant.Texture = FoliageTextureType.Fine;
            _plant.FoliageColor = "green";
            _plant.HardinessRangeLow = 0;
            _plant.HardinessRangeHigh = 0;
            _plant.Growth = GrowthType.Fast;
            _plant.WaterNeed = WaterNeedType.Mod;
            _plant.Evergreen = false;
            _plant.ImagePath = "~/img/chilopsis-linearis.jpg";
            _plant.PlantType = PlantType.Tree;
            _plant.PlantDescription = "Beautiful in summer, awful in winter; the graceful, willowy foliage and exotic orchid-like clusters are irresistible, but in winter, abundant seed pods hang on the branches for a terribly unkempt appearance. Desert Willow does best as a background tree.  The flower color ranges from nearly white to a showy red-violet.  Clusters of trumpet-shaped flowers appear on branch ends.  Select plants white in bloom to ensure getting your color preference."; 
            return _plant;
        }

        public PlantAdvancedModel GetSilkFloss()
        {
            _plant = new PlantAdvancedModel();
            _plant.PlantName = "Silk-Floss Tree";
            _plant.LatinName = "Chorisia speciosa";
            _plant.Height = 60;
            _plant.Width = 30;
            _plant.FlowerSeason = SeasonType.Fall;
            _plant.FlowerColor = "pink";
            _plant.Texture = FoliageTextureType.Coarse;
            _plant.FoliageColor = "green";
            _plant.HardinessRangeLow = 26;
            _plant.HardinessRangeHigh = 28;
            _plant.Growth = GrowthType.Mod;
            _plant.WaterNeed = WaterNeedType.Mod;
            _plant.Evergreen = false;
            _plant.ImagePath = "~/img/chorisia-speciosa.jpg";
            _plant.PlantType = PlantType.Tree;
            _plant.PlantDescription = "These green-barked branches are studded with enormous spines. Native to South America, the young trees need frost protection.  In the fall, all the foliage drops and beautiful lily-like flowers appear.  This species offers reliable flower color.  It is best used in large courtyards. Native to Brazil.";
            return _plant;
        }
    }
}