using AutoMapper;
using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Core.DTOs.PublisherDtos;
using CultureArt.Core.DTOs.PublisherEventDtos;
using CultureArt.Core.Entities.CultureArt.Core.Entities;
using CultureArt.Core.Repositories;
using CultureArt.Core.Services;
using CultureArt.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Service.Services
{
	public class PublisherService : Service<PublisherDto, Publisher	>, IPublisherService
	{
		private readonly IPublisherRepository _publisherRepository;
		public PublisherService(IGenericRepository<Publisher> repository, IUnitOfWork unitOfWork, IMapper mapper, IPublisherRepository publisherRepository) : base(repository, unitOfWork, mapper)
		{
			_publisherRepository = publisherRepository;
		}

		public async Task<CustomResponseDto<CreatePublisherDto>> AddAsync(CreatePublisherDto dto)
		{
			var entity = _mapper.Map<Publisher>(dto);
			await _publisherRepository.AddAsync(entity);
			await _unitOfWork.CommitAsync();
			var publisherDto = _mapper.Map<CreatePublisherDto>(entity);
			return CustomResponseDto<CreatePublisherDto>.Success(201,publisherDto);
		}

		public async Task<CustomResponseDto<PublisherWithEventDto>> GetSinglePublisherByIdWithEventAsync(int publisherId)
		{
			var publisher = await _publisherRepository.GetSinglePublisherByIdWithEventAsync(publisherId);
			//var publisherDto = _mapper.Map<PublisherWithEventDto>(publisher);
			var publisherDto = new PublisherWithEventDto()
			{
				Id = publisherId,
				Name = publisher.Name,
				WebSiteHomePageUrl = publisher.WebSiteHomePageUrl
			};
			if(publisher.Events.Count > 0)
			{
                var publisherEventDto = new List<PublisherEventDto>();

                foreach (var item in publisher.Events)
                {
                    var value = new PublisherEventDto()
                    {
                        PublisherId = item.PublisherId,
                        EventId = item.EventId,
                        Event = new Core.DTOs.EventDtos.EventDto()
                        {
                            Id = item.Event.Id,
                            Name = item.Event.Name,
                            EventStartDate = item.Event.EventStartDate,
                            EventEndDate = item.Event.EventEndDate,
                            EventStatus = item.Event.EventStatus,
                            ImageUrl = item.Event.ImageUrl,
                            EventAreaName = item.Event.AddressDetail.EventAreaName,
                        CategoryName = item.Event.Category.Name,
                            CityName = item.Event.AddressDetail.City.CityName
                        }

                    };
					publisherEventDto.Add(value);

                }
				publisherDto.Events = publisherEventDto.ToList();
            }

		

            return CustomResponseDto<PublisherWithEventDto>.Success(200,publisherDto);
		}

		public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(UpdatePublisherDto dto)
		{
			var value = _mapper.Map<Publisher>(dto);
			_publisherRepository.Update(value);
			await _unitOfWork.CommitAsync();
			return CustomResponseDto<NoContentDto>.Success(204);
		}

		protected override PublisherDto MapToDto(Publisher entity)
		{
			return _mapper.Map<PublisherDto>(entity);
		}
	}
}
