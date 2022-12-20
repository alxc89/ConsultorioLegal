using Microsoft.EntityFrameworkCore;
using src.api.Domain.Entities;

namespace src.api.Infrastructure.Database.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}