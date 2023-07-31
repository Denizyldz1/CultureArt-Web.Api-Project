using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Core.DTOs.CategoryDtos;
using CultureArt.Core.DTOs.PublisherDtos;
using CultureArt.Core.Entities.CultureArt.Core.Entities;

namespace CultureArt.Core.Services
{
	public interface IPublisherService : IService<PublisherDto, Publisher>
	{
		Task<CustomResponseDto<CreatePublisherDto>> AddAsync(CreatePublisherDto dto);
		Task<CustomResponseDto<NoContentDto>> UpdateAsync(UpdatePublisherDto dto);
		Task<CustomResponseDto<PublisherWithEventDto>> GetSinglePublisherByIdWithEventAsync(int publisherId);
	}
}
