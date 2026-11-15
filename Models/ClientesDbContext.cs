using Microsoft.EntityFrameworkCore;

namespace tarea_semana_3.Models
{
    public class ClientesDbContext : DbContext
    {
        public ClientesDbContext(DbContextOptions<ClientesDbContext> opciones) : base(opciones)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
