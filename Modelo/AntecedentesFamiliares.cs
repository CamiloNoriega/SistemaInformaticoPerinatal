

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("AntecedentesFamiliares")]
    public class AntecedentesFamiliares
    {
        [Key]
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public bool TBC { get; set; }
        public bool Diabetes { get; set; }
        public bool Hipertension { get; set; }
        public bool Preeclampsia { get; set; }
        public bool Eclampsia { get; set; }
        public bool OtraCondMedicaGrave { get; set; }


       
    }
}
