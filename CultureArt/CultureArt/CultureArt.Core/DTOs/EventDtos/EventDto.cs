using CultureArt.Core.Dto;
using CultureArt.Core.DTOs.AddressDetailDtos;
using CultureArt.Core.DTOs.CategoryDtos;
using CultureArt.Core.DTOs.CityDtos;
using CultureArt.Core.DTOs.EventFeatureDtos;
using CultureArt.Core.Enums;

namespace CultureArt.Core.DTOs.EventDtos
{
	public class EventDto: IEntityDto
	{
        public int Id { get; set; }
        public string? Name { get; set; }
		public DateTime EventStartDate { get; set; }
		public DateTime? EventEndDate { get; set; }
		public EventStatus EventStatus { get; set; }
		public string? ImageUrl { get; set; }
        public string? EventAreaName { get; set; }
        public string? CategoryName { get; set; }
        public string? CityName { get; set; }
    }
}
