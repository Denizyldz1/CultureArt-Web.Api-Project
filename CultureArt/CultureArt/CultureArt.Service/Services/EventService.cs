using AutoMapper;
using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Core.DTOs.EventDtos;
using CultureArt.Core.Entities;
using CultureArt.Core.Enums;
using CultureArt.Core.Repositories;
using CultureArt.Core.Services;
using CultureArt.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

namespace CultureArt.Service.Services
{
    public class EventService : Service<EventDto, Event>, IEventService
	{
		private readonly IEventRepository _eventRepository;
		private readonly IEventFeatureRepository _eventFeatureRepository;
		private readonly IPublisherEventRepository<PublisherEvent> _publisherEventRepository;
        public EventService(IGenericRepository<Event> repository, IUnitOfWork unitOfWork, IMapper mapper, IEventRepository eventRepository, IEventFeatureRepository eventFeatureRepository, IPublisherEventRepository<PublisherEvent> publisherEventRepository) : base(repository, unitOfWork, mapper)
        {
            _eventRepository = eventRepository;
            _eventFeatureRepository = eventFeatureRepository;
            _publisherEventRepository = publisherEventRepository;
        }
        public override async Task<CustomResponseDto<IEnumerable<EventDto>>> GetAllAsync()
        {
			var entities = await _eventRepository.GetAll().ToListAsync();
			var mapping = new List<EventDto>();
			foreach (var entity in entities)
			{

				mapping.Add(new EventDto()
				{
					Id = entity.Id,
					Name = entity.Name,
					EventAreaName = entity.AddressDetail.EventAreaName,
					EventStartDate = entity.EventStartDate,
					EventEndDate = entity.EventEndDate,
					ImageUrl = entity.ImageUrl,
					EventStatus = entity.EventStatus,
					CategoryName = entity.Category.Name,
					CityName = entity.AddressDetail.City.CityName

				});
			}
			return CustomResponseDto<IEnumerable<EventDto>>.Success(200, mapping);
        }

        public async Task<CustomResponseDto<CreateEventDto>> AddAsync(CreateEventDto dto)
		{
			var publishers = new HashSet<PublisherEvent>();
			if(dto.Publishers != null)
			{
                foreach (var item in dto.Publishers)
                {
					var publisherEvent = new PublisherEvent() { EventId = dto.Id,PublisherId = item.PublisherId,PublisherEventUrl = item.PublisherEventUrl };
					publishers.Add(publisherEvent);
                }
            }
			Event @event = new()
			{
				Name = dto.Name,
				EventStartDate = dto.EventStartDate,
				EventEndDate = dto.EventEndDate,
				ImageUrl = dto.ImageUrl,
				AddressDetailId = dto.AddressDetailId,
				CategoryId = dto.CategoryId,
				CityId = dto.CityId,
				//PublisherId = dto.PublisherId,
				//CompanyId = dto.CompanyId,
				EventFeature = new()
				{
					Title = dto.EventFeature.Title,
					Description = dto.EventFeature.Description,
					EventRules = dto.EventFeature.EventRules,
					Event= null

				}

			};
			@event.Publishers = publishers;
			//@event.EventFeature.Event = null;
			await _eventRepository.AddAsync(@event);
			await _unitOfWork.CommitAsync();
			CreateEventDto eventDto = new()
			{
				Id  = @event.Id,
				Name = @event.Name,
				EventStartDate = @event.EventStartDate,
				EventEndDate = @event.EventEndDate,
				ImageUrl = @event.ImageUrl,
				AddressDetailId = @event.AddressDetailId,
				CategoryId = @event.CategoryId,
				CityId = @event.CityId,
				EventFeature = new()
				{
					Title = dto.EventFeature.Title,
					Description = dto.EventFeature.Description,
					EventRules = dto.EventFeature.EventRules

				}
				//Publishers = @event.Publishers
			};
			return CustomResponseDto<CreateEventDto>.Success(201, eventDto);

		}

		public async Task<CustomResponseDto<NoContentDto>> ChangeStatus(int eventId, EventStatus status)
		{
			await _eventRepository.ChanceStatus(eventId, status);
			await _unitOfWork.CommitAsync();
			return CustomResponseDto<NoContentDto>.Success(204);
		}

		public async Task<CustomResponseDto<EventDtoWithAllConnectionEntities>> GetSingleEventByIdWithAllConnectionEntitiesAsync(int eventId)
		{
			var eventEntity = await _eventRepository.GetSingleEventByIdWithAllConnectionEntitiesAsync(eventId);
			var eventDto = _mapper.Map<EventDtoWithAllConnectionEntities>(eventEntity);	
			return CustomResponseDto<EventDtoWithAllConnectionEntities>.Success(200,eventDto);
		}

		public async Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id)
		{
			var value = await _eventRepository.GetByIdAsync(id);
			_eventRepository.Remove(value);
			await _unitOfWork.CommitAsync();
			return CustomResponseDto<NoContentDto>.Success(204);
		}

		public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(UpdateEventDto dto)
		{
			var eventFeature = await _eventFeatureRepository.GetByIdAsync(dto.Id);
			_eventFeatureRepository.Remove(eventFeature);
			var publisherList = new List<PublisherEvent>();

			foreach (var item in dto.Publishers)
			{
				var publisherDto = new PublisherEvent()
				{
					EventId = dto.Id,
					PublisherId = item.PublisherId,
					PublisherEventUrl = item.PublisherEventUrl,
				};
                publisherList.Add(publisherDto);
            }

			_publisherEventRepository.RemoveRange(publisherList);
            var publishers = new HashSet<PublisherEvent>();
            if (dto.Publishers != null)
            {
                foreach (var item in dto.Publishers)
                {
                    var publisherEvent = new PublisherEvent() { EventId = dto.Id, PublisherId = item.PublisherId, PublisherEventUrl = item.PublisherEventUrl };
                    publishers.Add(publisherEvent);
                }
            }

            Event @event = new()
			{
				Name = dto.Name,
				EventStartDate = dto.EventStartDate,
				EventEndDate = dto.EventEndDate,
				ImageUrl = dto.ImageUrl,
				AddressDetailId = dto.AddressDetailId,
				CategoryId = dto.CategoryId,
				CityId = dto.CityId,
				//PublisherId = dto.PublisherId,
				//CompanyId = dto.CompanyId,
				EventFeature = new()
				{
					Title = dto.EventFeature.Title,
					Description = dto.EventFeature.Description,
					EventRules = dto.EventFeature.EventRules				}

			};
            @event.Publishers = publishers;
            _eventRepository.Update(@event);
			await _unitOfWork.CommitAsync();
			return CustomResponseDto<NoContentDto>.Success(204);
		}

		protected override EventDto MapToDto(Event entity)
		{
			return _mapper.Map<EventDto>(entity);
		}
	}
}
