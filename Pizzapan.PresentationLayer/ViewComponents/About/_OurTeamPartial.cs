using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _OurTeamPartial: ViewComponent
    {
        private readonly IOurTeamService _ourTeamService;
        private readonly Context _context;

        public _OurTeamPartial(Context context, IOurTeamService ourTeamService)
        {
            _context = context;
            _ourTeamService = ourTeamService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.OurTeams.ToList();
            return View(values);
        }
    }
}

