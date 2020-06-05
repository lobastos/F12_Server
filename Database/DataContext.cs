using LibsServer.Model;
using Microsoft.EntityFrameworkCore;

namespace f12api.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseNpgsql("Host=localhost;Database=teste001;Username=postgres;Password=masterkey")
                .UseSnakeCaseNamingConvention();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Funcionario>( entity => 
                entity.Property(e => e.DataCadastro)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("NOW()")
                    .ValueGeneratedOnAdd()
            );
            modelBuilder.Entity<Funcionario>( entity => 
                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("NOW()")
                    .ValueGeneratedOnUpdate()
            );
        }
    }
}