using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class AuthController(SignUpViewModel signUpViewModel) : Controller
    {
        private readonly SignUpViewModel _signUpViewModel = signUpViewModel;

        public async Task<IActionResult> SignUp()
        {
            await _signUpViewModel.PopulateClientOptionsAsync();
            return View(_signUpViewModel);
        }

        [HttpPost]
        public IActionResult SignUp(SignUpForm formData)
        {
            if (!ModelState.IsValid)
            {
                _signUpViewModel.FormData = formData;
                return View(_signUpViewModel);
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
