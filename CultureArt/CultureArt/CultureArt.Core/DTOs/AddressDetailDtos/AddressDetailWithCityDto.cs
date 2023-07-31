using CultureArt.Core.DTOs.CityDtos;
using CultureArt.Core.Entities;

namespace CultureArt.Core.DTOs.AddressDetailDtos
{
	public class AddressDetailWithCityDto : AddressDetailDto
	{
		public CityDto? City { get; set; }
	}
}
