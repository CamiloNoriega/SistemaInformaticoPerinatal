using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class EnfermedadesMaternas
    {
        public int Id { get; set; }

        public bool UnaoMas { get; set; }
        public bool HTAPrevia { get; set; }
        public bool HTAInducidaEmbarazo { get; set; }
        public bool Preeclampsia { get; set; }
        public bool Eclampsia { get; set; }
        public bool Cardiopatia { get; set; }
        public bool Nefropatia { get; set; }
        public string Diabetes { get; set; }  // crear entidad 
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
        public string TdpSifilis { get; set; }  //  crear entidad 
        public string TdpVIH { get; set; }      //  crear entidad 

        public string TARV { get; set; }  //  crear entidad 
    }
}
