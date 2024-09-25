


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Paciente")]
    public class Paciente
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Localidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public  Etnia Etnia { get; set; }
        public bool Alfabeta { get; set; }
        public  NivelEstudios NivelEstudios { get; set; }
        public string AñoAprobado { get; set; }
        public  EstadoCivil EstadoCivil{ get; set; }
        public bool ViveSola { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }

    }
}