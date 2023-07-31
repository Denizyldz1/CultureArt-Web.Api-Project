using CultureArt.WEB.Models.CategoryModels;
using CultureArt.WEB.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CultureArt.WEB.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryApiService _addressDetailService;

        public CategoryController(CategoryApiService categoryApiService)
        {
            _addressDetailService = categoryApiService;
        }

        public async Task<IActionResult> Index()
        {
           var values = await _addressDetailService.GetAllAsync();
            return View(values);
        }
        public  IActionResult Save()
        {
            return View(new CategoryModel());
        }
        [HttpPost]
        public async Task<IActionResult> Save(CategoryModel categoryModel)
        {
            if(ModelState.IsValid)
            {
                await _addressDetailService.SaveAsync(categoryModel);
                return RedirectToAction(nameof(Index));
            }
            return View(categoryModel);
        }
        public async Task<IActionResult> Update(int id)
        {
            var category = await _addressDetailService.GetByIdAsync(id);
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                await _addressDetailService.UpdateAsync(categoryModel);
                return RedirectToAction(nameof(Index));
            }
            return View(categoryModel);
        }
        public async Task<IActionResult> Remove(int id)
        {
            await _addressDetailService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));

        }

    }
}
