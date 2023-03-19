using Microsoft.AspNetCore.Mvc;

namespace ShoppingWeb.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
