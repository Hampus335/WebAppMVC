using Infrastructure.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class ClientFactory
{
    public Client? Create(ClientEntity form) => new()
    {
        Name = form.Name
    };
}
