using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CultureArt.Core.Entities
{
	public class EventFeature
	{
		[ForeignKey("Event")]
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? EventRules { get; set; }
        public  Event? Event { get; set; }
	}
}
