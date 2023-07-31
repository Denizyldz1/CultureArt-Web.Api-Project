using CultureArt.WEB.Models;
using CultureArt.WEB.Models.CategoryModels;
using CultureArt.WEB.Models.CityModels;

namespace CultureArt.WEB.Services
{
    public class CityApiService
    {
        private  readonly HttpClient _httpClient;

        private const string cityEndpoint = "city";
        public CityApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CityModel>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CityModel>>>(cityEndpoint);
            return response.Data;
        }
        public async Task<CityModel> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<CityModel>>($"city/{id}");
            return response.Data;
        }
        //Şehir'deki etkinlik alanları
        public async Task<CityWithAddressDetailModel> GetByIdWithAddressDetail(int cityId)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<CityWithAddressDetailModel>>($"city/getsinglecitybyidwithaddressdetail/{cityId}");
            return response.Data;
        }

        //Şehirdeki etkinlikler
        public async Task<CityWithEventModel> GetByIdWithEvent(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<CityWithEventModel>>($"city/getsinglecitybyidwithevent/{id}");
            return response.Data;
        }
    }

}
