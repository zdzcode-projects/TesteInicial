using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace APITeste.Models
{
    public class EFDBContext : DbContext
    {
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
  
}
