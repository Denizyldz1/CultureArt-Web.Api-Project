using CultureArt.WEB.Models.CityModels;

namespace CultureArt.WEB.Models.AddressDetailModels
{
    public class AddressDetailWithCityModel:AddressDetailModel
    {
        public CityModel? City { get; set; }
    }
}
