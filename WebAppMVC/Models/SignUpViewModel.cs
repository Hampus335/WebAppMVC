using Microsoft.AspNetCore.Mvc.Rendering;
namespace WebAppMVC.Models
{
    public class SignUpViewModel
    {
        public SignUpForm FormData { get; set; } = new();
        public List<SelectListItem> ClientOptions = [];

        public SignUpViewModel()
        {

        }

        public async Task PopulateClientOptions()
        {

        }
    }
}
