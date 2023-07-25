using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzapan.DataAccessLayer.Concrete;
using PizzaPan.BusinessLayer.Abstract;
using System.Linq;

namespace Pizzapan.PresentationLayer.ViewComponents.Menu
{
    public class _MenuPartial:ViewComponent
    {
        private readonly IProductService _productService;
        private readonly Context _context;

        public _MenuPartial(IProductService productService, Context context)
        {
            _productService = productService;
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Categories.Include(x => x.Products).ToList();
            return View(values);
        }
    }
}
