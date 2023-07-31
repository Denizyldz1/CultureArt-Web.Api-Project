using CultureArt.WEB.Models.EventModels;

namespace CultureArt.WEB.Models.PublisherModels
{
    public class PublisherWithEventModel :PublisherModel
    {
        public EventModel? Event { get; set; }
    }
}
