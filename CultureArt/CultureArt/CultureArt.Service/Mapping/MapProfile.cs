using AutoMapper;
using CultureArt.Core.DTOs.AddressDetailDtos;
using CultureArt.Core.DTOs.CategoryDtos;
using CultureArt.Core.DTOs.CityDtos;
using CultureArt.Core.DTOs.EventDtos;
using CultureArt.Core.DTOs.EventFeatureDtos;
using CultureArt.Core.DTOs.PublisherDtos;
using CultureArt.Core.DTOs.PublisherEventDtos;
using CultureArt.Core.Entities;
using CultureArt.Core.Entities.CultureArt.Core.Entities;

namespace CultureArt.Service.Mapping
{
	public class MapProfile : Profile
	{
        public MapProfile()
        {
			#region AddressDetail
			CreateMap<AddressDetail, AddressDetailDto>().ReverseMap();
			CreateMap<CreateAddressDetailDto, AddressDetail>().ReverseMap();
			CreateMap<UpdateAddressDetailDto, AddressDetail>();
			CreateMap<AddressDetail, AddressDetailWithCityDto>();
			#endregion
			#region City
			CreateMap<City, CityDto>().ReverseMap();
			CreateMap<City, CityWithAddressDetailDto>();
			CreateMap<City, CityWithEventDto>();
			#endregion
			#region Category
			CreateMap<Category, CategoryDto>().ReverseMap();
			CreateMap<CreateCategoryDto, Category>().ReverseMap();
			CreateMap<UpdateCategoryDto, Category>();
			CreateMap<Category,CategoryWithEventDto>();

			CreateMap<Category, Category>().ReverseMap();
			#endregion
			#region Publisher
			CreateMap<Publisher,PublisherDto>().ReverseMap();
			CreateMap<CreatePublisherDto,Publisher>().ReverseMap();
			CreateMap<UpdatePublisherDto, Publisher>();
			CreateMap<Publisher, PublisherWithEventDto>();
			#endregion
			#region Event
			CreateMap<Event, EventDto>().ReverseMap();
			CreateMap<CreateEventDto, Event>().ReverseMap();
			CreateMap<UpdateEventDto, Event>();
			CreateMap<Event, EventDtoWithAllConnectionEntities>().ReverseMap();
			#endregion
			CreateMap<EventFeature, EventFeatureDto>();
			CreateMap<PublisherEvent, PublisherEventDto>();



		}
	}
}
