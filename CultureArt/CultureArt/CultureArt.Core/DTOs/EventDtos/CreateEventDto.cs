using CultureArt.Core.Dto;
using CultureArt.Core.DTOs.EventFeatureDtos;
using CultureArt.Core.DTOs.PublisherEventDtos;

namespace CultureArt.Core.DTOs.EventDtos
{
    public class CreateEventDto : BaseCreateDto
	{
		public string? Name { get; set; }
		public DateTime EventStartDate { get; set; }
		public DateTime? EventEndDate { get; set; }
		public string? ImageUrl { get; set; }
		public int AddressDetailId { get; set; }
		public int CategoryId { get; set; }
		public int CityId { get; set; }
		public EventFeatureDto? EventFeature { get; set; }
		public List<PublisherEventMatchDto>? Publishers { get; set; }
	}
}
