
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entidades
{

    public class DatosPerinatales
    {
        public int Id { get; set; }
        public string LugarControlPrenatal { get; set; }
        public string LugarPartoAborto { get; set; }
        public string NumeroDeIdentidad { get; set; }

        public Paciente Paciente { get; set; }
      
    }
}
