using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CultureArt.Core.Entities
{
    public class AddressDetail:BaseEntity
	{
        public string? EventAreaName { get; set; }
        public string? StreetAddress { get; set; }
		public int PostCode { get; set; }
		public int CityId { get; set; }
        [JsonIgnore]
        public virtual City? City { get; set; }
		public ICollection<Event>? Events { get; set; }

	}
}
