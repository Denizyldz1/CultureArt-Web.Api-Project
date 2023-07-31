using CultureArt.WEB.Models;
using CultureArt.WEB.Models.CategoryModels;

namespace CultureArt.WEB.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient _httpClient;

        private const string categoryEndpoint = "category";
        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CategoryModel>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CategoryModel>>>(categoryEndpoint);
            return response.Data;
        }
        public async Task<CategoryModel> SaveAsync(CategoryModel model)
        {
            var response = await _httpClient.PostAsJsonAsync(categoryEndpoint, model);
            if (!response.IsSuccessStatusCode) return null;
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<CategoryModel>>();
            return responseBody.Data;
        }
        public async Task<bool> UpdateAsync(CategoryModel model)
        {
            var response = await _httpClient.PutAsJsonAsync(categoryEndpoint, model);
            return response.IsSuccessStatusCode;
        }
        public async Task<CategoryModel> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<CategoryModel>>($"category/{id}");
            return response.Data;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"category/{id}");
            return response.IsSuccessStatusCode;
        }
        public async Task<CategoryWithEventModel> GetByIdWithEvent(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<CategoryWithEventModel>>($"category/getsinglecategorybyidwithevent/{id}");
            return response.Data;
        }
    }
}
