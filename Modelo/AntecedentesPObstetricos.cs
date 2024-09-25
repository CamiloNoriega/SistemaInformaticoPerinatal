

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("AntecedentesPObstetricos")]
    public class AntecedentesPObstetricos
    {
        [Key]
        public int Id { get; set; }

        public bool CirugiaGUrinaria { get; set; }
        public bool Infertilidad { get; set; }
        public bool Cardiopatia { get; set; }
        public bool Nefropatia { get; set; }
        public bool Violencia { get; set; }
        public bool VIH { get; set; }
        public string GestasPrevias { get; set; }
        public string NacidosVivos { get; set; }
        public string Viven { get; set; }
        public string NacidosMuertos { get; set; }
        public string MuertosPrimeraSemana { get; set; }
        public string EmbarazoEctopico { get; set; }
        public string NumeroPartos { get; set; }
        public string PartosVaginales { get; set; }
        public string Cesareas { get; set; }
        public   PesoRecienNacido PesoRecienNacido { get; set; }
        public string Abortos { get; set; }
        public DateTime FechaFinEmbarazoAnterior { get; set; }
        public UsoAnticonceptivos UsoAnticonseptivos { get; set; }
        public bool AntecedentesGemelares { get; set; }
        public bool EmbarazoPlaneado { get; set; }


    }
}
