using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.ContactMe
{
    public class _MessagePartial : ViewComponent
    {
        private readonly IContactUsService _contactUsService;
        private readonly IContactService _contactService;

        public _MessagePartial(IContactUsService contactUsService, IContactService contactService)
        {
            _contactUsService = contactUsService;
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _contactUsService.TGetByID(1);

            ViewBag.address = value.Adress;
            ViewBag.number = value.Number;
            ViewBag.openingHours = value.OpeningHours;
            ViewBag.email = value.Email;

            return View();
        }

    }
}
