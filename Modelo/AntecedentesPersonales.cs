

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("AntecedentesPersonales")]
    public class AntecedentesPersonales
    {
        [Key]

        public int Id { get; set; }
        public bool TBC { get; set; }
        public DiabetesAPersonales DiabetesAPersonales { get; set; }  
        public bool Hipertension { get; set; }
        public bool Preeclampsia { get; set; }
        public bool Eclampsia { get; set; }
        public bool OtraCondMedicaGrave { get; set; }


        public AntecedentesFamiliares antecedentesFamiliares { get; set; }
        public AntecedentesPObstetricos antecedentesPObstetricos { get; set; }
    }
}

