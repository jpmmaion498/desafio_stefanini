using Microsoft.EntityFrameworkCore;

namespace desafio_stefanini.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; } 

        public DbSet<Cidade> Cidades { get; set; }   
    }
}
