using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Modelo
{
    public class DBGestionSistemaInformaticoP : DbContext
    {
        public DbSet<EstadoCivil> Civiles { get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConfigurationManager.ConnectionStrings["GestionActividadFisica"].ConnectionString);
        }

    }
}
