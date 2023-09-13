using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}