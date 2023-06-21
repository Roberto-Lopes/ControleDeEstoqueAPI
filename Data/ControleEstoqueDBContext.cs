using ControleDeEstoqueAPI.Data.Map;
using ControleDeEstoqueAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoqueAPI.Data
{
    public class ControleEstoqueDBContext : DbContext
    {
        
        public ControleEstoqueDBContext(DbContextOptions<ControleEstoqueDBContext> options)
            : base(options)
        {
            
        }

        public DbSet<ProdutoModel> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
