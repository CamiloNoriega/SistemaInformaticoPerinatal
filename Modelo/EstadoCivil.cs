using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("EstadoCivil")]
    public class EstadoCivil
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdPaciente { get; set; }
        public virtual ICollection<Paciente> Paciente { get; set; }
    }
}
