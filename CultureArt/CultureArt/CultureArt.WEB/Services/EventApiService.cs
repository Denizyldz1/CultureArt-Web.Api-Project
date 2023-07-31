using CultureArt.WEB.Models;
using CultureArt.WEB.Models.EventModels;
using System.Net.Http.Json;

namespace CultureArt.WEB.Services
{
    public class EventApiService
    {
        private readonly HttpClient _httpClient;
        private const string eventEndpoint = "event";

        public EventApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        // 2 farklı GetById methodu mevcut ilki sadece Event modeli getirmekte ikinci bağlı olduğu bütün tabloları ile birlikte getirmekte
        public async Task<List<EventModel>> GetAllEvent()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<EventModel>>>(eventEndpoint);
            return response.Data;
        }
        public async Task<EventModel> GetByIdEvent(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<EventModel>>($"event/{id}");
            return response.Data;
        }
        public async Task<EventWithAllEntitiesModel> GetByIdWithAllEntities(int eventId)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<EventWithAllEntitiesModel>>($"event/getsingleeventwithallconnectionentites/{eventId}");
            return response.Data;
        }
        public async Task<CreateEventModel> SaveAsync(CreateEventModel model)
        {
            var response = await _httpClient.PostAsJsonAsync(eventEndpoint, model);
            if (!response.IsSuccessStatusCode) return null;
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<CreateEventModel>>();
            return responseBody.Data;
        }
        public async Task<bool> UpdateAsync(CreateEventModel model)
        {
            var response = await _httpClient.PutAsJsonAsync(eventEndpoint, model);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"event/{id}");
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> ChangeStatus(int eventId,string statu)
        {
            var response = await _httpClient.PutAsync($"event/changestatus/{eventId}?statu={statu}",null);
            return response.IsSuccessStatusCode;
        }
    }
}
