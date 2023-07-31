using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Core.DTOs.AddressDetailDtos;
using CultureArt.Core.DTOs.CityDtos;
using CultureArt.Core.Entities;

namespace CultureArt.Core.Services
{
	public interface IAddressDetailService : IService<AddressDetailDto, AddressDetail>
	{
		Task<CustomResponseDto<CreateAddressDetailDto>> AddAsync(CreateAddressDetailDto dto);
		Task<CustomResponseDto<NoContentDto>> UpdateAsync(UpdateAddressDetailDto dto);
		Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id);
		Task<CustomResponseDto<List<AddressDetailWithCityDto>>> GetAddressDetailWithCityAsync();
		Task<CustomResponseDto<AddressDetailWithCityDto>> GetSingleAddressDetailByIdWithCityAsync(int addressDetailId);
	}
}
