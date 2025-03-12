using Infrastructure.Entities;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected DataContext()
    {

    }

    public virtual DbSet<ClientEntity> Clients { get; set; }
}
