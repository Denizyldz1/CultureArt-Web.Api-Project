using CultureArt.API.Filters;
using CultureArt.Core.DTOs.EventDtos;
using CultureArt.Core.Entities;
using CultureArt.Core.Enums;
using CultureArt.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CultureArt.API.Controllers
{
    public class EventController : CustomBaseController
	{
		private readonly IEventService _eventService;

		public EventController(IEventService eventService)
		{
			_eventService = eventService;
		}
		[ServiceFilter(typeof(NotFoundFilter<Event>))]
		[HttpGet("[action]/{eventId}")]
		public async Task<IActionResult> GetSingleEventWithAllConnectionEntites(int eventId)
		{
			return CreateActionResult(await _eventService.GetSingleEventByIdWithAllConnectionEntitiesAsync(eventId));
		}

		[HttpGet]
		public async Task<IActionResult> All()
		{
			var events = await _eventService.GetAllAsync();
			return CreateActionResult(events);
		}
		[ServiceFilter(typeof(NotFoundFilter<Event>))]
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var value = await _eventService.GetByIdAsync(id);
			return CreateActionResult(value);
		}
		[HttpPost]
		public async Task<IActionResult> Save(CreateEventDto dto)
		{
			var value = await _eventService.AddAsync(dto);
			return CreateActionResult(value);
		}
		[HttpPut]
		public async Task<IActionResult> Update(UpdateEventDto dto)
		{
			var value = await _eventService.UpdateAsync(dto);
			return CreateActionResult(value);
		}
		[ServiceFilter(typeof(NotFoundFilter<Event>))]
		[HttpDelete("{id}")]
		public async Task<IActionResult> Remove(int id)
		{
			var value = await _eventService.RemoveAsync(id);
			return CreateActionResult(value);

		}
		[ServiceFilter(typeof(NotFoundFilter<Event>))]
		[HttpPut("[action]/{eventId}")]
		public async Task<IActionResult> ChangeStatus(int eventId, [FromQuery] string statu)
		{
			
			EventStatus status = new();
			if(statu == "0")
			{
				status = EventStatus.Pasif;
			}
            if (statu == "1")
            {
                status = EventStatus.Aktif;
            }
            if (statu == "3")
            {
                status = EventStatus.Geçmiş;
            }
            var value = await _eventService.ChangeStatus(eventId, status);
			return CreateActionResult(value);
		}
	}
}
