using CultureArt.WEB.Models.PublisherModels;
using CultureArt.WEB.Services;
using Microsoft.AspNetCore.Mvc;

namespace CultureArt.WEB.Controllers
{
    public class PublisherController : Controller
    {
        private readonly PublisherApiService _addressDetailService;

        public PublisherController(PublisherApiService publisherApiService)
        {
            _addressDetailService = publisherApiService;
        }

        public async Task<IActionResult> Index()
        {
           var values = await _addressDetailService.GetAllAsync();
            return View(values);
        }
        public IActionResult Save()
        {
            return View(new PublisherModel());
        }
        [HttpPost]
        public async Task<IActionResult> Save(PublisherModel publisherModel)
        {
            if (ModelState.IsValid)
            {
                await _addressDetailService.SaveAsync(publisherModel);
                return RedirectToAction(nameof(Index));
            }
            return View(publisherModel);
        }
        public async Task<IActionResult> Update(int id)
        {
            var value = await _addressDetailService.GetByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(PublisherModel publisherModel)
        {
            if (ModelState.IsValid)
            {
                await _addressDetailService.UpdateAsync(publisherModel);
                return RedirectToAction(nameof(Index));
            }
            return View(publisherModel);
        }
    }
}
