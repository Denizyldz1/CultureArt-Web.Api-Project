using CultureArt.WEB.Models.AddressDetailModels;
using CultureArt.WEB.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

namespace CultureArt.WEB.Controllers
{
    public class AddressDetailController : Controller
    {
        private readonly AddressDetailApiService _addressDetailService;
        private readonly CityApiService _cityApiService;

        public AddressDetailController(AddressDetailApiService addressDetailService, CityApiService cityApiService)
        {
            _addressDetailService = addressDetailService;
            _cityApiService = cityApiService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _addressDetailService.GetAllWithCityAsync();
            return View(values);
        }
        public async Task<IActionResult> Save()
        {
            var cityDto= await _cityApiService.GetAllAsync();
            ViewBag.Cities = new SelectList(cityDto, "Id", "CityName");
            return View(new AddressDetailModel());
        }
        [HttpPost]
        public async Task<IActionResult> Save(AddressDetailModel model)
        {
            if (ModelState.IsValid)
            {
                await _addressDetailService.SaveAsync(model);
                return RedirectToAction(nameof(Index));
            }
            var cityDto = await _cityApiService.GetAllAsync();
            ViewBag.Cities = new SelectList(cityDto, "Id", "CityName");
            return View(model);
        }
        public async Task<IActionResult> Update(int id)
        {
            var value = await _addressDetailService.GetByIdWithCityAsync(id);
            var cityDto = await _cityApiService.GetAllAsync();
            ViewBag.Cities = new SelectList(cityDto, "Id", "CityName",value.CityId);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(AddressDetailModel model)
        {
            if (ModelState.IsValid)
            {
                await _addressDetailService.UpdateAsync(model);
                return RedirectToAction(nameof(Index));
            }
            var cityDto = await _cityApiService.GetAllAsync();
            ViewBag.Cities = new SelectList(cityDto, "Id", "CityName", model.CityId);
            return View(model);
        }
        public async Task<IActionResult> Remove(int id)
        {
            await _addressDetailService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> GetAddressDetailsByCityId(int cityId)
        {
            var values = await _cityApiService.GetByIdWithAddressDetail(cityId);
            if (values.AddressDetails.Count > 0)
            {
                return Json(values.AddressDetails);
            }
            return Json(new List<AddressDetailModel>()
            {
                new AddressDetailModel() {
                 Id = 0,
                EventAreaName = "Etkinlik alanı bulunamadı"}
            });
        }
    }
}
