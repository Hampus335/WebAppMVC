using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace WebAppMVC.Models
{
    public class SignUpViewModel
    {
        private readonly ClientService _clientService;
        public SignUpViewModel(ClientService clientService)
        {
            _clientService = clientService;
            Task.Run(PopulateClientOptionsAsync);
        }
        public SignUpForm FormData { get; set; } = new();
        public List<SelectListItem> ClientOptions = [];

        public async Task PopulateClientOptionsAsync()
        {
            var clients = await _clientService.GetClientsAsync();
            ClientOptions = [.. clients.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            })];
        }
    }
}
