using Microsoft.EntityFrameworkCore;
using MyFesta.API.Models;

namespace MyFesta.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<OfertaServico> Ofertas { get; set; }
        public DbSet<PortifolioImagem> Portfolios { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }    
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar Precisão do Preço (Decimal)
            modelBuilder.Entity<Pacote>()
                .Property(p => p.Preco)
                .HasPrecision(18, 2);

            // Garantir que Categoria tenha nomes únicos
            modelBuilder.Entity<Categoria>()
                .HasIndex(c => c.Nome)
                .IsUnique();
        }
    }
}