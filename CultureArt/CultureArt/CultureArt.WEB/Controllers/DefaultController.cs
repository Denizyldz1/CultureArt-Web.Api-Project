using Microsoft.AspNetCore.Mvc;

namespace CultureArt.WEB.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
