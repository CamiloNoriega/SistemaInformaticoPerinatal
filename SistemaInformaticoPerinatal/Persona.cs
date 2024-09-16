using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformaticoPerinatal
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Localidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Etnia { get; set; }
        public bool Alfabeta { get; set; }
        public string NivelDeEstudios { get; set; }
        public int AñoAprobado { get; set; }
        public string EstadoCivil { get; set; }
        public bool ViveSola { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}