using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.Contact
{
    public class _ContactMePartial : ViewComponent
    {
        private readonly IContactService _contactService;
        private readonly IContactUsService _contactUsService;

        public _ContactMePartial(IContactService contactService, IContactUsService contactUsService)
        {
            _contactService = contactService;
            _contactUsService = contactUsService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _contactUsService.TGetByID(1);

            ViewBag.address = value.Adress;
            ViewBag.mail = value.Email;
            ViewBag.phone = value.Number;
            ViewBag.date = value.OpeningHours;
            

            return View("Contact", "Default");
        }


    }
}
