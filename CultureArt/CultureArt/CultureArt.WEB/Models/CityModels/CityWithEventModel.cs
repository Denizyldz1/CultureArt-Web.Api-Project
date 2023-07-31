using CultureArt.WEB.Models.EventModels;

namespace CultureArt.WEB.Models.CityModels
{
    public class CityWithEventModel:CityModel
    {
        public EventModel? Event { get; set; }
    }
}