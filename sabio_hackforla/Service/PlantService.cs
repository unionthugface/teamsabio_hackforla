using Newtonsoft.Json.Linq;
using sabio_hackforla.Constants;
using sabio_hackforla.Data;
using sabio_hackforla.Data.RecommendDTO;
using sabio_hackforla.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;

namespace sabio_hackforla.Service
{
    public class PlantService
    {
        private static String ApiKey = ConfigurationManager.AppSettings["ApiKey"];
        private static String ApiId = ConfigurationManager.AppSettings["ApiId"];
        private static String _BaseUrl = "http://garden.vsapi01.com/api-search/";


        public JToken GetPlantFromJustVisual(string imagePath)
        {
            WebClient client = new WebClient();

            string uri;

            uri = _BaseUrl + "by-url?url=" + imagePath + "&apiid=" + ApiId + "&apikey=" + ApiKey;
            string source = client.DownloadString(uri);

            JToken o = JToken.Parse(source);
            //jSON.deserialize<Plant>(source);

            return o;
        }

        public Plant GetPlantById(Guid plantId)
        {
            Plant plant = null;
            return plant;
        }

        public IEnumerable<PlantAdvancedModel> GetAllAlternativePlants()
        {
            List<PlantAdvancedModel> plants = new List<PlantAdvancedModel>();

            GroundCoverDTO dto = new GroundCoverDTO();
            plants.Add(dto.GetEuphorbia());
            plants.Add(dto.GetOenothera());
            plants.Add(dto.GetZauschneria());

            ShrubDTO shrubdto = new ShrubDTO();
            plants.Add(shrubdto.GetCaesalpinia());
            plants.Add(shrubdto.GetFouquieria());
            plants.Add(shrubdto.GetLarrea());

            TreeDTO treedto = new TreeDTO();
            plants.Add(treedto.GetBluePaloVerde());
            plants.Add(treedto.GetDesertWillow());
            plants.Add(treedto.GetSilkFloss());

            DecorativeDTO decodto = new DecorativeDTO();
            plants.Add(decodto.GetEchinocactus());
            plants.Add(decodto.GetLotus());
            plants.Add(decodto.GetOpuntia());

            return plants;
        }

        public IEnumerable<PlantAdvancedModel> GetAlternativePlantsByType(PlantType pType)
        {
            List<PlantAdvancedModel> plants = new List<PlantAdvancedModel>();

            switch ((int)pType)
            {
                case (int)PlantType.GroundCover:
                    GroundCoverDTO dto = new GroundCoverDTO();
                    plants.Add(dto.GetEuphorbia());
                    plants.Add(dto.GetOenothera());
                    plants.Add(dto.GetZauschneria());
                    break;

                case (int)PlantType.Shrub:
                    ShrubDTO shrubdto = new ShrubDTO();
                    plants.Add(shrubdto.GetCaesalpinia());
                    plants.Add(shrubdto.GetFouquieria());
                    plants.Add(shrubdto.GetLarrea());
                    break;

                case (int)PlantType.Tree:
                    TreeDTO treedto = new TreeDTO();
                    plants.Add(treedto.GetBluePaloVerde());
                    plants.Add(treedto.GetDesertWillow());
                    plants.Add(treedto.GetSilkFloss());
                    break;

                case (int)PlantType.Decorative:
                    DecorativeDTO decodto = new DecorativeDTO();
                    plants.Add(decodto.GetEchinocactus());
                    plants.Add(decodto.GetLotus());
                    plants.Add(decodto.GetOpuntia());
                    break;
            }

            return plants;
        }

        public List<GardenResponseModel> GetGarden(Guid? gardenId)
        {
            List<GardenResponseModel> plants = new List<GardenResponseModel>();
            GardenResponseModel plant = new GardenResponseModel();
            plant.PlantName = "Blazing Star";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/5/58/Mentzelialindleyi.jpg/220px-Mentzelialindleyi.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Gentiana algida";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Gentiana_algida_arctic_gentians.jpg/220px-Gentiana_algida_arctic_gentians.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Valley Oak";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/86/Valley_Oak_Mount_Diablo.jpg/220px-Valley_Oak_Mount_Diablo.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "California Flannelbush";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Fremontodendron_californicum.jpg/220px-Fremontodendron_californicum.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Joshua Tree";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Joshua_Tree_NP_-_Joshua_Tree_2.jpg/220px-Joshua_Tree_NP_-_Joshua_Tree_2.jpg";

            plant = new GardenResponseModel();
            plant.PlantName = "Creosote Bush";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Larrea_tridentata_Anza-Borrego.jpg/220px-Larrea_tridentata_Anza-Borrego.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "California Buckwheat";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/3/38/California_Buckwheat_%284776487540%29.jpg/220px-California_Buckwheat_%284776487540%29.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Dutchman's Pipe";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Aristolochia_californica_flower_2004-02-23.jpg/170px-Aristolochia_californica_flower_2004-02-23.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Festuca Californica";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Festucacalifornica0.jpg/220px-Festucacalifornica0.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Coast Dudleya";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fd/Dudleya_caespitosa_5.jpg/170px-Dudleya_caespitosa_5.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Anigozanthos";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://commons.wikimedia.org/wiki/File:Anigozanthos_with_dew_in_SF_Botanical_Garden.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Castilleja applegatei";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Applegate%27s_Indian_paintbrush.jpg/246px-Applegate%27s_Indian_paintbrush.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Ferocactus cylindraceaus";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Barrel_Cactus_01.jpg/294px-Barrel_Cactus_01.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Opuntia basilaris";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://commons.wikimedia.org/wiki/File:Beavertail_Cactus.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Prosposis veluntina";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Prosopis_velutina_Anza-Borrego.jpg/314px-Prosopis_velutina_Anza-Borrego.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Washingtonia filfera";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/72/California_fan_palm_01.jpg/140px-California_fan_palm_01.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Quercos lobata";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Conejo_Valley_hiking_trails_December_2010_001.jpg/280px-Conejo_Valley_hiking_trails_December_2010_001.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Nicotiana obtusifolia";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Nicotiana_obtusifolia_Anza-Borrego.jpg/314px-Nicotiana_obtusifolia_Anza-Borrego.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Larrea tridentata";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Larrea_tridentata_Anza-Borrego.jpg/314px-Larrea_tridentata_Anza-Borrego.jpg";
            plants.Add(plant);

            plant = new GardenResponseModel();
            plant.PlantName = "Eriogonum fasciculatum";
            plant.PlantDescription = "Liatris pycnostachya, known as the prairie blazing star, is a perennial plant that belongs to the aster family. There are thirty species of this particular wildflower in North America, seven of which reside in Indiana  - namely rough, northern, plains, cylindrical marsh and the prairie blazing star.";
            plant.ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/3/38/California_Buckwheat_%284776487540%29.jpg/280px-California_Buckwheat_%284776487540%29.jpg";
            plants.Add(plant);

            return plants;
        }

        public List<Plant> GetPlantsByZip(string zip)
        {
            List<Plant> plants = null;
            return plants;
        }

        public List<GeoCode> GetNurseries(string zip = null, GeoCode location = null)
        {
            List<GeoCode> nurseries = null;

            if (!string.IsNullOrEmpty(zip))
            {

            }
            if (location != null)
            {

            }

            return nurseries;
        }
    }
}