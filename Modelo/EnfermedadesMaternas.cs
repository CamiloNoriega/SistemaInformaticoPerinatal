using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("EnfermedadesMaternas")]
    public class EnfermedadesMaternas
    {
        [Key]
        public int Id { get; set; }
        public int IdPaciente { get; set; }

        public bool UnaoMas { get; set; }
        public bool HTAPrevia { get; set; }
        public bool HTAInducidaEmbarazo { get; set; }
        public bool Preeclampsia { get; set; }
        public bool Eclampsia { get; set; }
        public bool Cardiopatia { get; set; }
        public bool Nefropatia { get; set; }
        public int IdDiabetesEnfermedades { get; set; }
        public DiabetesEnfermedades DiabetesEnfermedades { get; set; }
        public bool InfeccionObular { get; set; }
        public bool InfeccionUrinaria { get; set; }
        public bool AmenazaPartoPreter { get; set; }
        public bool RCIU { get; set; }
        public bool RoturaPremMembranas { get; set; }
        public bool Anemia { get; set; }
        public bool OtraCondGrave { get; set; }

        // Hemorragias
        public bool HemorragiaPrimerTrimestre { get; set; }
        public bool HemorragiaSegundoTrimestre { get; set; }
        public bool HemorragiaTercerTrimestre { get; set; }
        public bool HemorragiaPostparto { get; set; }
        public bool HemorragiaInfeccionPuerperal { get; set; }

        // TDP Prueba
        public int IdTdpSifilis { get; set; }
        public TdpSifilis TdpSifilis { get; set; }
        public int IdTdpVIH { get; set; }
        public TdpVIH TdpVIH { get; set; }
        public int IdTARV { get; set; }
        public TARV TARV { get; set; }


        public virtual Paciente Paciente { get; set; }
    }
}
