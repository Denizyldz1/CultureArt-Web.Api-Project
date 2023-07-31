using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.DTOs.CityDtos;
using CultureArt.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.Services
{
	public interface ICityService : IService<CityDto, City>
	{
		Task<CustomResponseDto<CityWithAddressDetailDto>> GetSingleCityByIdWithAddressDetailAsync(int cityId);
		Task<CustomResponseDto<CityWithEventDto>> GetSingleCityByIdWithEventAsync(int cityId);
	}
}
