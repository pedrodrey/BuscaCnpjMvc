using Microsoft.EntityFrameworkCore;
using BuscaCnpjMvc.Models;

namespace BuscaCnpjMvc.Data
{
    public class BuscaCnpjMvcContext : DbContext
    {
        public BuscaCnpjMvcContext(DbContextOptions<BuscaCnpjMvcContext> options)
            : base(options)
        {
        }

        public DbSet<CnpjResponse> CnpjResponse { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CnpjResponse>(entity =>
            {
                entity.OwnsMany(
                    e => e.Qsa,
                    qsa =>
                    {
                        qsa.ToTable("Qsa");
                        qsa.Property<int>("Sequencial").ValueGeneratedOnAdd();
                        qsa.HasKey("Sequencial");
                        qsa.WithOwner().HasForeignKey("Cnpj");
                        qsa.Property<string>("Cnpj");
                        qsa.Property<string>("Nome");
                        qsa.Property<string>("Qualificacao");
                        qsa.Property<string>("PaisOrigem");
                        qsa.Property<string>("RepresentanteLegal");
                    }
                );

                entity.OwnsMany(
                    e => e.AtividadePrincipal,
                    atv =>
                    {
                        atv.ToTable("AtividadePrincipal");
                        atv.Property<int>("Sequencial").ValueGeneratedOnAdd();
                        atv.HasKey("Sequencial");
                        atv.WithOwner().HasForeignKey("Cnpj");
                        atv.Property<string>("Cnpj");

                        atv.Property<string>("Codigo");
                        atv.Property<string>("Descricao");
                    }
                );

                entity.OwnsMany(
                    e => e.AtividadeSecundaria,
                    atv =>
                    {
                        atv.ToTable("AtividadeSecundaria");
                        atv.Property<int>("Sequencial").ValueGeneratedOnAdd();
                        atv.HasKey("Sequencial");
                        atv.WithOwner().HasForeignKey("Cnpj");
                        atv.Property<string>("Cnpj");

                        atv.Property<string>("Codigo");
                        atv.Property<string>("Descricao");
                    }
                );

                entity.OwnsOne(e => e.Simples, s => {
                    s.Property<bool>("IsEmpty").IsRequired().HasDefaultValue(true);
                    s.WithOwner();
                });

                entity.OwnsOne(e => e.Simei, s => {
                    s.Property<bool>("IsEmpty").IsRequired().HasDefaultValue(true);
                    s.WithOwner();
                });

                entity.OwnsOne(e => e.Billing, b => {
                    b.Property<bool>("IsEmpty").IsRequired().HasDefaultValue(true);
                    b.WithOwner();
                });
            });
        }
    }
}