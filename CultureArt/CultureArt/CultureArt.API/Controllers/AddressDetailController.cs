using CultureArt.API.Filters;
using CultureArt.Core.DTOs.AddressDetailDtos;
using CultureArt.Core.Entities;
using CultureArt.Core.Services;
using CultureArt.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CultureArt.API.Controllers
{
	public class AddressDetailController : CustomBaseController
	{
		private readonly IAddressDetailService _service;

		public AddressDetailController(IAddressDetailService service)
		{
			_service = service;
		}
		[HttpGet("[action]")]
		public async Task<IActionResult> GetAddressDetailsWithCity()
		{
			return CreateActionResult(await _service.GetAddressDetailWithCityAsync());
		}
		[ServiceFilter(typeof(NotFoundFilter<AddressDetail>))]
		[HttpGet("[action]/{addressDetailId}")]
		public async Task<IActionResult> GetSingleAddressDetailByIdWithCity(int addressDetailId)
		{
			return CreateActionResult(await _service.GetSingleAddressDetailByIdWithCityAsync(addressDetailId));
		}

		[HttpGet]
		public async Task<IActionResult> All()
		{
			var addressDetails = await _service.GetAllAsync();
			return CreateActionResult(addressDetails);
		}
		[ServiceFilter(typeof(NotFoundFilter<AddressDetail>))]
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var addressDetail = await _service.GetByIdAsync(id);
			return CreateActionResult(addressDetail);
		}
		[HttpPost]
		public async Task<IActionResult> Save(CreateAddressDetailDto dto)
		{
			var value = await _service.AddAsync(dto);
			return CreateActionResult(value);
		}
		[HttpPut]
		public async Task<IActionResult> Update(UpdateAddressDetailDto dto)
		{
			var value = await _service.UpdateAsync(dto);
			return CreateActionResult(value);
		}
		[ServiceFilter(typeof(NotFoundFilter<AddressDetail>))]
		[HttpDelete("{id}")]
		public async Task<IActionResult> Remove(int id)
		{
			var value = await _service.RemoveAsync(id);
			return CreateActionResult(value);

		}
	}
}
