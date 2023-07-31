using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Core.DTOs.EventDtos;
using CultureArt.Core.Entities;
using CultureArt.Core.Enums;

namespace CultureArt.Core.Services
{
    public interface IEventService : IService<EventDto, Event>
	{
		Task<CustomResponseDto<CreateEventDto>> AddAsync(CreateEventDto dto);
		Task<CustomResponseDto<NoContentDto>> UpdateAsync(UpdateEventDto dto);
		Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id);
		Task<CustomResponseDto<EventDtoWithAllConnectionEntities>> GetSingleEventByIdWithAllConnectionEntitiesAsync(int eventId);
		Task<CustomResponseDto<NoContentDto>> ChangeStatus(int eventId, EventStatus status);


	}
}
