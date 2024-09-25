using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("DiabetesEnfermedades")]
    public class DiabetesEnfermedades
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int IdEnfermedadesMaternas { get; set; }
        public virtual ICollection<EnfermedadesMaternas> EnfermedadesMaternas { get; set; }
    }
}
