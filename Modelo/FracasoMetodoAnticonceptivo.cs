using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("FracasoMetodoAnticonceptivo")]
    public class FracasoMetodoAnticonceptivo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
