using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Modelo
{
    public class DBGestionSistemaInformaticoP : DbContext
    {
        public DbSet<EstadoCivil> Civiles { get; set;}




    }
}
