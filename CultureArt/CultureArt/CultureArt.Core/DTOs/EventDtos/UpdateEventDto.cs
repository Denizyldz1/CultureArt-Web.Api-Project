using CultureArt.Core.DTOs.EventFeatureDtos;
using CultureArt.Core.DTOs.PublisherEventDtos;
using CultureArt.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs.EventDtos
{
	public class UpdateEventDto : BaseUpdateDto
	{
		public string? Name { get; set; }
		public DateTime EventStartDate { get; set; }
		public DateTime? EventEndDate { get; set; }
		public EventStatus EventStatus { get; set; }
		public string? ImageUrl { get; set; }
		public int CompanyId { get; set; }
		public int AddressDetailId { get; set; }
		public int CategoryId { get; set; }
		public int CityId { get; set; }
		public EventFeatureDto? EventFeature { get; set; }
        public IEnumerable<PublisherEventUpdateDto>? Publishers { get; set; }
    }
}
