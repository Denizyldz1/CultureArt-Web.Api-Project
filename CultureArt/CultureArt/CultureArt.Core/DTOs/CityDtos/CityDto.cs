using CultureArt.Core.Dto;

namespace CultureArt.Core.DTOs.CityDtos
{
	public class CityDto : IEntityDto
	{
        public  int  Id { get; set; }
		public string? CityName { get; set; }
    }
}
