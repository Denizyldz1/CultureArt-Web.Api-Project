using CultureArt.WEB.Models.AddressDetailModels;

namespace CultureArt.WEB.Models.CityModels
{
    public class CityWithAddressDetailModel:CityModel
    {
        public List<AddressDetailModel>? AddressDetails { get; set; }
    }
}