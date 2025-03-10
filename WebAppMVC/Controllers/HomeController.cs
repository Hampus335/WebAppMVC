using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Services;

namespace WebAppMVC.Controllers
{
    public class HomeController(ProductService productService) : Controller
    {
        private readonly ProductService _productService = productService;

        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            
            return View(_productService.GetProducts());
        }
        [Route("about")]
        public IActionResult About()
        {
            ViewData["Title"] = "About Us";
            return View();
        }
        [Route("contacts")]
        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact Us";
            return View();
        }
    }
}
