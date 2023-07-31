using CultureArt.WEB.Models;
using CultureArt.WEB.Models.CategoryModels;
using CultureArt.WEB.Models.PublisherModels;
using Microsoft.AspNetCore.Mvc;

namespace CultureArt.WEB.Services
{
    public class PublisherApiService
    {
        // Get - Post-Put-GetId - GetByIdWithEvent
        private readonly HttpClient _httpClient;

        private const string publisherEndpoint = "publisher";
        public PublisherApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PublisherModel>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<PublisherModel>>>(publisherEndpoint);
            return response.Data;
        }
        public async Task<PublisherModel> SaveAsync(PublisherModel model)
        {
            var response = await _httpClient.PostAsJsonAsync(publisherEndpoint, model);
            if (!response.IsSuccessStatusCode) return null;
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<PublisherModel>>();
            return responseBody.Data;
        }
        public async Task<bool> UpdateAsync(PublisherModel model)
        {
            var response = await _httpClient.PutAsJsonAsync(publisherEndpoint, model);
            return response.IsSuccessStatusCode;
        }
        public async Task<PublisherModel> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<PublisherModel>>($"publisher/{id}");
            return response.Data;
        }
        public async Task<PublisherWithEventModel> GetByIdWithEvent(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<PublisherWithEventModel>>($"publisher/getsinglepublisherbyidwithevent/{id}");
            return response.Data;
        }

    }
}
