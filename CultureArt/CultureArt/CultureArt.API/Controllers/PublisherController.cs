using CultureArt.API.Filters;
using CultureArt.Core.DTOs.PublisherDtos;
using CultureArt.Core.Entities.CultureArt.Core.Entities;
using CultureArt.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CultureArt.API.Controllers
{

	public class PublisherController : CustomBaseController
	{
		private readonly IPublisherService _publisherService;

		public PublisherController(IPublisherService publisherService)
		{
			_publisherService = publisherService;
		}
		[ServiceFilter(typeof(NotFoundFilter<Publisher>))]
		[HttpGet("[action]/{publisherId}")]
		public async Task<IActionResult> GetSinglePublisherByIdWithEvent(int publisherId)
		{
			return CreateActionResult(await _publisherService.GetSinglePublisherByIdWithEventAsync(publisherId));
		}
		[HttpGet]
		public async Task<IActionResult> All()
		{
			var publishers = await _publisherService.GetAllAsync();
			return CreateActionResult(publishers);
		}
		[ServiceFilter(typeof(NotFoundFilter<Publisher>))]
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var publisher = await _publisherService.GetByIdAsync(id);
			return CreateActionResult(publisher);
		}
		[HttpPost]
		public async Task<IActionResult> Save(CreatePublisherDto dto)
		{
			var value = await _publisherService.AddAsync(dto);
			return CreateActionResult(value);
		}
		[HttpPut]
		public async Task<IActionResult> Update(UpdatePublisherDto dto)
		{
			var publisher = await _publisherService.UpdateAsync(dto);
			return CreateActionResult(publisher);
		}
	}
}
