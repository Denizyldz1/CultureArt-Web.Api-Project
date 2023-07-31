using CultureArt.Core.DTOs.EventDtos;
using CultureArt.Core.DTOs.PublisherEventDtos;

namespace CultureArt.Core.DTOs.PublisherDtos
{
	public class PublisherWithEventDto : PublisherDto
	{
		public List<PublisherEventDto>? Events { get; set; }
	}
}
