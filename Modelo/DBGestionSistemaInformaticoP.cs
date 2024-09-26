using Microsoft.EntityFrameworkCore;
using Modelo;
using System.Configuration;

namespace Modelo
{
    public class DBGestionSistemaInformaticoP : DbContext
    {
        public DbSet<AntecedentesFamiliares> AntecedentesFamiliares { get; set; }
        public DbSet<AntecedentesPersonales> AntecedentesPersonales { get; set; }
        public DbSet<AntecedentesPObstetricos> AntecedentesPObstetricos { get; set; }
        public DbSet<DatosPerinatales> DatosPerinatales { get; set; }
        public DbSet<EnfermedadesMaternas> EnfermedadesMaternas { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set;}
        public DbSet<Etnia> Etina  { get; set; }
        public DbSet<UsoAnticonceptivos> UsoAnticonceptivos { get; set; }
        public DbSet<PesoRecienNacido> PesoRecienNacidos { get; set; }
        public DbSet<NivelEstudios> NivelEstudios { get; set; }
        public DbSet<TARV> TARV { get; set; }
        public DbSet<TdpSifilis> TdpSifilis { get; set; }
        public DbSet<TdpVIH> TdpVIH { get; set; }
        public DbSet<DiabetesAPersonales> DiabetesAPersonales { get; set; }
        public DbSet<DiabetesEnfermedades> DiabetesEnfermedades { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConfigurationManager.ConnectionStrings["SIPerinatal"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.Entity<Paciente>()
                .HasMany(e => e.EnfermedadesMaternas)
                .WithOne(e => e.Paciente)
                .HasForeignKey(e => e.IdPaciente);

            Builder.Entity<Paciente>()
                .HasMany(e => e.DatosPerinatales)
                .WithOne(e => e.Paciente)
                .HasForeignKey(e => e.IdPaciente);

            Builder.Entity<Paciente>()
                .HasMany(e => e.AntecedentesFamiliares)
                .WithOne(e => e.Paciente)
                .HasForeignKey(e => e.IdPaciente);

            Builder.Entity<Paciente>()
                .HasMany(e => e.AntecedentesPObstetricos)
                .WithOne(e => e.Paciente)
                .HasForeignKey(e => e.IdPaciente);


            Builder.Entity<Paciente>()
                .HasMany(e => e.AntecedentesPersonales)
                .WithOne(e => e.Paciente)
                .HasForeignKey(e => e.IdPaciente);


            Builder.Entity<Paciente>()
                .HasMany(e => e.Usuario)
                .WithOne(e => e.Paciente)
                .HasForeignKey(e => e.IdPaciente);

            Builder.Entity<EstadoCivil>()
                .HasMany(e => e.Paciente)
                .WithOne(e => e.EstadoCivil)
                .HasForeignKey(e => e.IdEstadoCivil);

            Builder.Entity<Etnia>()
                .HasMany(e => e.Paciente)
                .WithOne(e => e.Etnia)
                .HasForeignKey(e => e.IdEtnia);

            Builder.Entity<UsoAnticonceptivos>()
                .HasMany(e => e.AntecedentesPObstetricos)
                .WithOne(e => e.UsoAnticonceptivos)
                .HasForeignKey(e => e.IdUsoAnticonceptivos);

            Builder.Entity<PesoRecienNacido>()
                .HasMany(e => e.AntecedentesPObstetricos)
                .WithOne(e => e.PesoRecienNacido)
                .HasForeignKey(e => e.IdPesoRecienNacido);

            Builder.Entity<NivelEstudios>()
                .HasMany(e => e.Paciente)
                .WithOne(e => e.NivelEstudios)
                .HasForeignKey(e => e.IdNivelEstudios);

            Builder.Entity<TARV>()
                .HasMany(e => e.EnfermedadesMaternas)
                .WithOne(e => e.TARV)
                .HasForeignKey(e => e.IdTARV);

            Builder.Entity<TdpSifilis>()
                .HasMany(e => e.EnfermedadesMaternas)
                .WithOne(e => e.TdpSifilis)
                .HasForeignKey(e => e.IdTdpSifilis);

            Builder.Entity<TdpVIH>()
               .HasMany(e => e.EnfermedadesMaternas)
               .WithOne(e => e.TdpVIH)
               .HasForeignKey(e => e.IdTdpVIH);

            Builder.Entity<DiabetesAPersonales>()
               .HasMany(e => e.AntecedentesPersonales)
               .WithOne(e => e.DiabetesAPersonales)
               .HasForeignKey(e => e.DiabetesAPersonales);

            Builder.Entity<DiabetesEnfermedades>()
              .HasMany(e => e.EnfermedadesMaternas)
              .WithOne(e => e.DiabetesEnfermedades)
              .HasForeignKey(e => e.DiabetesEnfermedades);


        }

    }
}
