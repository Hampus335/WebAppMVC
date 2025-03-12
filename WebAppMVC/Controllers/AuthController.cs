using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class AuthController : Controller
    {
        private readonly ClientService _clientService;
        private SignUpViewModel _signUpViewModel;

        public AuthController(ClientService clientService)
        {
            _clientService = clientService;
            _signUpViewModel = new SignUpViewModel(_clientService);
        }

        public IActionResult SignUp()
        {
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
