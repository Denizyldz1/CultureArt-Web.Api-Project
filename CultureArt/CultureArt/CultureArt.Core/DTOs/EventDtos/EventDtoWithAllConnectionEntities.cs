using CultureArt.Core.DTOs.AddressDetailDtos;
using CultureArt.Core.DTOs.CategoryDtos;
using CultureArt.Core.DTOs.CityDtos;
using CultureArt.Core.DTOs.EventFeatureDtos;
using CultureArt.Core.DTOs.PublisherDtos;
using CultureArt.Core.DTOs.PublisherEventDtos;
using CultureArt.Core.Enums;

namespace CultureArt.Core.DTOs.EventDtos
{
	public class EventDtoWithAllConnectionEntities : EventDto
	{
        public EventFeatureDto? EventFeature { get; set; }
        public List<PublisherEventDto>? Publishers { get; set; }


    }
}
