using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AntecedentesPObstetricos
    {
        public int Id { get; set; }

        public bool CirugiaGUrinaria { get; set; }
        public bool Infertilidad { get; set; }
        public bool Cardioparía { get; set; }
        public bool Nefropatía { get; set; }
        public bool Violencia { get; set; }
        public bool VIH { get; set; }
        public int GestasPrevias { get; set; }
        public int NacidosVivos { get; set; }
        public int Viven { get; set; }
        public int NacidosMuertos { get; set; }
        public int MuertosPrimeraSemana { get; set; }
        public int EmbarazoEctopico { get; set; }
        public int NumeroPartos { get; set; }
        public int PartosVaginales { get; set; }
        public int Cesareas { get; set; }
        public bool PesoRecienNacido { get; set; }
        public int Abortos { get; set; }
        public bool TresAbortosConsecutivos { get; set; }
        public DateTime FechaFinEmbarazoAnterior { get; set; }
        public bool UsoAnticonceptivos { get; set; } //REVISAR
        public bool AntecedentesGemelares { get; set; }
        public bool EmbarazoPlaneado { get; set; }


    }
}
