using Microsoft.AspNetCore.Mvc;

namespace CultureArt.WEB.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
