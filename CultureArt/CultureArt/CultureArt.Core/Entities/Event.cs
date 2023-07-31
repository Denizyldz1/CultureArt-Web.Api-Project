using CultureArt.Core.Entities.CultureArt.Core.Entities;
using CultureArt.Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CultureArt.Core.Entities
{
    public class Event :BaseEntity
	{
        public Event()
        {
            this.EventStatus = EventStatus.Beklemede;
            // Event üzerinden Yayıncı oluşturmak veya var olan birden fazla yayıncıları match'lemek
            Publishers = new HashSet<PublisherEvent>();
        }
        public string? Name { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public EventStatus EventStatus { get; set; }
		public string? ImageUrl { get; set; }
		public int AddressDetailId { get; set; }
        public int CategoryId { get; set; }
        public int CityId { get; set; }

		// Navigation Properties

		public AddressDetail? AddressDetail { get; set; }
		public Category? Category { get; set; }
        // City tutmamızın sebebi istanbul'daki etkinlikler gibi şehire özel sayfaları oluşturmak
        public City? City { get; set; }
        public  ICollection<PublisherEvent>? Publishers { get; set; }

        // Bire bir ilişki
        public EventFeature? EventFeature { get; set; }


	}
}
