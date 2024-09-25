using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("DiabetesAPersonales")]
    public class DiabetesAPersonales
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int IdAntecedentesPersonales { get; set; }
        public virtual ICollection<AntecedentesPersonales> AntecedentesPersonales { get; set; }
    }
}
