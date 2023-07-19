using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.title1 = "Her gün Pizza Yiyin";
            ViewBag.title2 = "Sevdiğiniz Pizzaları Paylaşın";

            return View();
        }
    }
}
