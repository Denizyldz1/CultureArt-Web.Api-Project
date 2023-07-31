using System.Text.Json.Serialization;

namespace CultureArt.Core.Entities
{
    public class City : IEntity
	{
		public int Id { get; set; }
		public string? CityName { get; set; }
		// Bir şehrin birden fazla adresi ve etkinliği olabilir.

		public  ICollection<AddressDetail>? AddressDetails { get; set; }
		public ICollection<Event>? Events { get; set; }

	}
}
