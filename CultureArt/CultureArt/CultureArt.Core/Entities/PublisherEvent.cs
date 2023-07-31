using CultureArt.Core.Entities.CultureArt.Core.Entities;

namespace CultureArt.Core.Entities
{
	// CrossTable
	public class PublisherEvent
	{
        public int PublisherId { get; set; }
        public int EventId { get; set; }
        public string? PublisherEventUrl { get; set; }
        public  Publisher? Publisher { get; set; }
        public  Event? Event { get; set; }
    }
}
