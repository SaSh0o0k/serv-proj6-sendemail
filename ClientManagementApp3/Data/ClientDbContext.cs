using ClientManagementApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientManagementApp3.Data
{
    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options)
        {
        }

        public ClientDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=clients.db");
            optionsBuilder.EnableServiceProviderCaching(false);
        }
    }
}
