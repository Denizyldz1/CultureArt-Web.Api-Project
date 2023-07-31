using AutoMapper;
using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.DTOs.CityDtos;
using CultureArt.Core.Entities;
using CultureArt.Core.Repositories;
using CultureArt.Core.Services;
using CultureArt.Core.UnitOfWorks;

namespace CultureArt.Service.Services
{
	public class CityService : Service<CityDto, City>, ICityService
	{
		private readonly ICityRepository _cityRepository;
		public CityService(IGenericRepository<City> repository, IUnitOfWork unitOfWork, IMapper mapper, ICityRepository cityRepository) : base(repository, unitOfWork, mapper)
		{
			_cityRepository = cityRepository;
		}

		public async Task<CustomResponseDto<CityWithAddressDetailDto>> GetSingleCityByIdWithAddressDetailAsync(int cityId)
		{
			var city = await _cityRepository.GetSingleCityByIdWithAddressDetailAsync(cityId);
			var cityDto = _mapper.Map<CityWithAddressDetailDto>(city);
			return CustomResponseDto<CityWithAddressDetailDto>.Success(200, cityDto);
		}

		public async Task<CustomResponseDto<CityWithEventDto>> GetSingleCityByIdWithEventAsync(int cityId)
		{
			var city = await _cityRepository.GetSingleCityByIdWithEventAsync(cityId);
			var cityDto = _mapper.Map<CityWithEventDto>(city);
			return CustomResponseDto<CityWithEventDto>.Success(200, cityDto);
		}

		protected override CityDto MapToDto(City entity)
		{
			return _mapper.Map<CityDto>(entity);
		}
	}
}
