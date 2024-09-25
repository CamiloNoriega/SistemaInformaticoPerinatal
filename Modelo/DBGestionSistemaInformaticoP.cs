using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Modelo
{
    public class DBGestionSistemaInformaticoP : DbContext
    {
        public DbSet<EstadoCivil> EstadoCivil { get; set;}
        public DbSet<Etnia> Etina  { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConfigurationManager.ConnectionStrings["SIPerinatal"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);


            Builder.Entity<EstadoCivil>()
                .HasMany(e => e.Paciente)
                .WithOne(e => e.EstadoCivil)
                .HasForeignKey(e => e.IdEstadoCivil);

            Builder.Entity<Etnia>()
                .HasMany(e => e.Paciente)
                .WithOne(e => e.Etnia)
                .HasForeignKey(e => e.IdEtnia);
        }

    }
}
