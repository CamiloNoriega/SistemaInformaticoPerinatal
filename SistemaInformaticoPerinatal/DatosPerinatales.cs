using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformaticoPerinatal
{
    internal class DatosPerinatales
    {
        [Key]
        public int Id { get; set; }
        public string LugarControlPrenatal { get; set; }
        public string LugarPartoAborto { get; set; }
        public string NumeroDeIdentidad { get; set; }

        // Relación con la clase Paciente
        public Persona persona { get; set; }
    }
}
