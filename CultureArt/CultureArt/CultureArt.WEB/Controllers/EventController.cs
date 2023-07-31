using CultureArt.Core.Enums;
using CultureArt.WEB.Models.AddressDetailModels;
using CultureArt.WEB.Models.EventModels;
using CultureArt.WEB.Models.PublisherModels;
using CultureArt.WEB.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Eventing.Reader;

namespace CultureArt.WEB.Controllers
{
    public class EventController : Controller
    {
        private readonly EventApiService _eventService;
        private readonly CategoryApiService _categoryService;
        private readonly CityApiService _cityService;
        private readonly PublisherApiService _publisherService;

        public EventController(EventApiService eventService, CategoryApiService categoryService, CityApiService cityService, PublisherApiService publisherService)
        {
            _eventService = eventService;
            _categoryService = categoryService;
            _cityService = cityService;
            _publisherService = publisherService;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _eventService.GetAllEvent();
            return View(values);
        }
        public async Task<IActionResult> Save()
        {
            var categories = await _categoryService.GetAllAsync();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            var cities = await _cityService.GetAllAsync();
            ViewBag.Cities = new SelectList(cities, "Id", "CityName");
            var publishers = await _publisherService.GetAllAsync();
            ViewBag.Publishers = publishers;
            return View(new CreateEventModel());
        }
        [HttpPost]
        public async Task<IActionResult> Save (CreateEventModel eventModel)
        {
            var publisherList = new List<PublisherModel>();
            foreach (var item in eventModel.PublisherEventUrls)
            {
                if (item.Value != null)
                {
                    publisherList.Add(new PublisherModel
                    {
                        Id = item.Key,
                        WebSiteHomePageUrl = item.Value
                    });
                }
            }
            eventModel.Publishers = publisherList;

            if(ModelState.IsValid)
            {
                await _eventService.SaveAsync(eventModel);
                return RedirectToAction(nameof(Index));
            }
            var categories = await _categoryService.GetAllAsync();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            var cities = await _cityService.GetAllAsync();
            ViewBag.Cities = new SelectList(cities, "Id", "CityName");
            var publishers = await _publisherService.GetAllAsync();
            ViewBag.Publishers = publishers;
            return View(eventModel);
        }
        //public async Task<IActionResult> Update(int id)
        //{
        //    var value = await _eventService.GetByIdWithAllEntities(id);
        //    var categories = await _categoryService.GetAllAsync();
        //    ViewBag.Categories = new SelectList(categories, "Id", "Name");
        //    var cities = await _cityService.GetAllAsync();
        //    ViewBag.Cities = new SelectList(cities, "Id", "CityName");
        //    var publishers = await _publisherService.GetAllAsync();
        //    ViewBag.Publishers = publishers;
        //    return View(value);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Update(AddressDetailModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _addressDetailService.UpdateAsync(model);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    var cityDto = await _cityApiService.GetAllAsync();
        //    ViewBag.Cities = new SelectList(cityDto, "Id", "CityName", model.CityId);
        //    return View(model);
        //}
        public async Task<IActionResult> Remove(int id)
        {
            await _eventService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> ChangeStatus(int id,string status)
        {
            await _eventService.ChangeStatus(id, status);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ViewDetail(int id)
        {
            var values = await _eventService.GetByIdWithAllEntities(id);
            return View(values);
        }
        
    }
}
