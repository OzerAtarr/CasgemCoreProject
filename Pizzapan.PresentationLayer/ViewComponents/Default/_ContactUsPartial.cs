using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using System.Linq;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _ContactUsPartial:ViewComponent
    {
        private readonly IContactUsService _contactUsService;

        public _ContactUsPartial(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _contactUsService.TGetByID(1);
            ViewBag.adress = value.Adress;
            ViewBag.number = value.Number;
            ViewBag.email = value.Email;
            ViewBag.openingHours = value.OpeningHours;
            return View(value);
        }
    }
}
