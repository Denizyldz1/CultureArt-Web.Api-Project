using CultureArt.API.Filters;
using CultureArt.Core.DTOs.AddressDetailDtos;
using CultureArt.Core.DTOs.CategoryDtos;
using CultureArt.Core.Entities;
using CultureArt.Core.Services;
using CultureArt.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CultureArt.API.Controllers
{

	public class CategoryController : CustomBaseController
	{
		private readonly ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}
		[ServiceFilter(typeof(NotFoundFilter<Category>))]
		[HttpGet("[action]/{categoryId}")]
		public async Task<IActionResult> GetSingleCategoryByIdWithEvent(int categoryId)
		{
			return CreateActionResult(await _categoryService.GetSingleCategoryByIdWithEventAsync(categoryId));
		}
		[HttpGet]
		public async Task<IActionResult> All()
		{
			var categories = await _categoryService.GetAllAsync();
			return CreateActionResult(categories);
		}
		[ServiceFilter(typeof(NotFoundFilter<Category>))]
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var category = await _categoryService.GetByIdAsync(id);
			return CreateActionResult(category);
		}
		[HttpPost]
		public async Task<IActionResult> Save(CreateCategoryDto dto)
		{
			var value = await _categoryService.AddAsync(dto);
			return CreateActionResult(value);
		}
		[HttpPost("[Action]")]
		public async Task<IActionResult> SaveAll(IEnumerable<CreateCategoryDto> dto)
		{
			var value = await _categoryService.AddRandeAsync(dto);
			return CreateActionResult(value);
		}
		[HttpPut]
		public async Task<IActionResult> Update(UpdateCategoryDto dto)
		{
			var category = await _categoryService.UpdateAsync(dto);
			return CreateActionResult(category);
		}
		[ServiceFilter(typeof(NotFoundFilter<Category>))]
		[HttpDelete("{id}")]
		public async Task<IActionResult> Remove(int id)
		{
			var value = await _categoryService.RemoveAsync(id);
			return CreateActionResult(value);

		}
	}
}
