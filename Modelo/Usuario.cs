using Modelo;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public int IdPaciente { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
