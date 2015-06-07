using sabio_hackforla.Constants;
using sabio_hackforla.Data;
using sabio_hackforla.Data.RecommendDTO;
using sabio_hackforla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace sabio_hackforla.Service
{
    public class PlantService
    {
        public Plant GetPlantFromJustVisual(string imagePath)
        {
            Plant plant = null;
            WebClient client = new WebClient();
            client.BaseAddress = "http://garden.vsapi01.com/api-search/";
            return plant;
        }

        public Plant GetPlantById(Guid plantId)
        {
            Plant plant = null;
            return plant;
        }

        public IEnumerable<PlantAdvancedModel> GetAlternativePlants(PlantType pType)
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

        public List<Plant> GetGarden(Guid? gardenId)
        {
            List<Plant> plants = null;
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