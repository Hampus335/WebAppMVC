using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUpForm formData)
        {
            if (!ModelState.IsValid)
                return View();
            else
                return View(formData);
        }
        [Route("signin")]
        public IActionResult SignIn()
        {
            return View();
        }
        [Route("signout")]
        public new IActionResult SignOut()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
