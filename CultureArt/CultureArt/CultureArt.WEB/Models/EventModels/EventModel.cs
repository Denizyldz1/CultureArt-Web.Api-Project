using System.ComponentModel.DataAnnotations;

namespace CultureArt.WEB.Models.EventModels
{
    public class EventModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public int EventStatus { get; set; }
        public string? ImageUrl { get; set; }
        public string? EventAreaName { get; set; }
        public int AddressDetailId { get; set; }
        public string? CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string? CityName { get; set; }
        public int CityId { get; set; }
    }
}
