using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class AuthController : Controller
    {
        private SignUpViewModel _signUpViewModel = new();
        public IActionResult SignUp()
        {
            return View(_signUpViewModel);
        }
        [HttpPost]
        public IActionResult SignUp(SignUpForm formData)
        {
            if (!ModelState.IsValid)
            {
                if (!ModelState.IsValid)
                {
                    _signUpViewModel.FormData = formData;
                    return View(_signUpViewModel);
                }
                return View(formData);
            }
            return View();
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
