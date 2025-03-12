using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public class ClientService(ClientRepository clientRepostitory, ClientFactory clientFactory)
{
    private ClientRepository _clientRepository = clientRepostitory;
    private ClientFactory _customerFactory = clientFactory;

    public async Task<IEnumerable<Client?>> GetClientsAsync()
    {
        var entities = await _clientRepository.GetAllAsync();

        var customers = entities.Select(_customerFactory.Create);

        return customers;
    }
}
