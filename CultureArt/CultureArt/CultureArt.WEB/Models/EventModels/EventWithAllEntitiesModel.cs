using CultureArt.WEB.Models.PublisherModels;

namespace CultureArt.WEB.Models.EventModels
{
    public class EventWithAllEntitiesModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public int EventStatus { get; set; }
        public string? ImageUrl { get; set; }
        public string? EventAreaName { get; set; }
        public string? CategoryName { get; set; }
        public string? CityName { get; set; }
        public EventFeatureModel? EventFeature { get; set; }
        public List<PublisherModel>? Publishers { get; set; }
    }
}
