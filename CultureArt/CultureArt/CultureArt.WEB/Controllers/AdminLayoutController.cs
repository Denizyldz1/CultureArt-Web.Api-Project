using Microsoft.AspNetCore.Mvc;

namespace CultureArt.WEB.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
    }
}
