using CultureArt.Core.DTOs.EventDtos;

namespace CultureArt.Core.DTOs.CategoryDtos
{
	public class CategoryWithEventDto : CategoryDto
	{
		public List<EventDto>? Events { get; set; }
	}
}
