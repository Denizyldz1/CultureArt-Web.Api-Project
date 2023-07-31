using CultureArt.WEB.Models;
using CultureArt.WEB.Models.AddressDetailModels;

namespace CultureArt.WEB.Services
{
    public class AddressDetailApiService
    {
        // GetAll ve GetById'de Şehir ile birlkite getirme olarak düzenlendi
        private readonly HttpClient _httpClient;

        private const string addressDetailEndpoint = "addressdetail";
        public AddressDetailApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<AddressDetailWithCityModel>> GetAllWithCityAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<AddressDetailWithCityModel>>>("addressdetail/getaddressdetailswithcity");
            return response.Data;
        }
        public async Task<AddressDetailModel> SaveAsync(AddressDetailModel model)
        {
            var response = await _httpClient.PostAsJsonAsync(addressDetailEndpoint, model);
            if (!response.IsSuccessStatusCode) return null;
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<AddressDetailModel>>();
            return responseBody.Data;
        }
        public async Task<bool> UpdateAsync(AddressDetailModel model)
        {
            var response = await _httpClient.PutAsJsonAsync(addressDetailEndpoint, model);
            return response.IsSuccessStatusCode;
        }
        public async Task<AddressDetailWithCityModel> GetByIdWithCityAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<AddressDetailWithCityModel>>($"addressdetail/getsingleaddressdetailbyidwithcity/{id}");
            return response.Data;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"addressdetail/{id}");
            return response.IsSuccessStatusCode;
        }
      
    }
}
