using CultureArt.API.Filters;
using CultureArt.Core.DTOs.AddressDetailDtos;
using CultureArt.Core.DTOs.CityDtos;
using CultureArt.Core.Entities;
using CultureArt.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CultureArt.API.Controllers
{
	public class CityController : CustomBaseController
	{
		private readonly ICityService _cityService;

		public CityController(ICityService cityService)
		{
			_cityService = cityService;
		}
		[HttpGet]
		public async Task<IActionResult> All()
		{
			var cities = await _cityService.GetAllAsync();
			return CreateActionResult(cities);
		}
		[ServiceFilter(typeof(NotFoundFilter<City>))]
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var city = await _cityService.GetByIdAsync(id);
			return CreateActionResult(city);
		}
		[ServiceFilter(typeof(NotFoundFilter<City>))]
		[HttpGet("[action]/{cityId}")]
		public async Task<IActionResult> GetSingleCityByIdWithAddressDetail(int cityId)
		{
			return CreateActionResult(await _cityService.GetSingleCityByIdWithAddressDetailAsync(cityId));
		}
		[ServiceFilter(typeof(NotFoundFilter<City>))]
		[HttpGet("[action]/{cityId}")]
		public async Task<IActionResult> GetSingleCityByIdWithEvent(int cityId)
		{
			return CreateActionResult(await _cityService.GetSingleCityByIdWithEventAsync(cityId));
		}
	}
}

