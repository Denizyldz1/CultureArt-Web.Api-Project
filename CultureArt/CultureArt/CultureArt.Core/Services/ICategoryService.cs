using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Core.DTOs.AddressDetailDtos;
using CultureArt.Core.DTOs.CategoryDtos;
using CultureArt.Core.DTOs.CityDtos;
using CultureArt.Core.Entities;

namespace CultureArt.Core.Services
{
	public interface ICategoryService : IService<CategoryDto, Category>
	{
		Task<CustomResponseDto<CreateCategoryDto>> AddAsync(CreateCategoryDto dto);
		Task<CustomResponseDto<IEnumerable<CreateCategoryDto>>> AddRandeAsync(IEnumerable<CreateCategoryDto> dtos);
		Task<CustomResponseDto<NoContentDto>> UpdateAsync(UpdateCategoryDto dto);
		Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id);
		Task<CustomResponseDto<CategoryWithEventDto>> GetSingleCategoryByIdWithEventAsync(int categoryId);

	}
}
