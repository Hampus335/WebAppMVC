using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public class    ClientRepository(DataContext dataContext)
{
    private readonly DataContext _context = dataContext;

    //create
    public async Task<int> AddAsync(ClientEntity clientEntity)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(clientEntity);

            await _context.AddAsync(clientEntity);
            var result = await _context.SaveChangesAsync();
            return result;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return default;
        }
    }

    //read

    public async Task<IEnumerable<ClientEntity>> GetAllAsync()
    {
        var enteties = await _context.Clients.ToListAsync();
        return enteties;
    }

    public async Task<ClientEntity?> GetAsync(Expression<Func<ClientEntity, bool>> expression)
    {
        var entity = await _context.Clients.FirstOrDefaultAsync(expression);
        return entity;
    }

    //update

    //delete
}
