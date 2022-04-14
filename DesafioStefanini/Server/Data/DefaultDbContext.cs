using DesafioStefanini.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioStefanini.Server.Data
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> pessoas { get; set; }
        public DbSet<Cidade> cidades { get; set; }
    }
}
