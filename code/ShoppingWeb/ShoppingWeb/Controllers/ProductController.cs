using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingWeb.Models;
using System.Linq;

namespace ShoppingWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly dbMarketsContext _context;
        public ProductController(dbMarketsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var product =_context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId== id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
         
            return View(product);
        }
    }
}
