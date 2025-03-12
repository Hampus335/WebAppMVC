using Infrastructure.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class ClientFactory
{
    public Client? Create(Client form) => new()
    {
        Name = form.Name
    };
}
