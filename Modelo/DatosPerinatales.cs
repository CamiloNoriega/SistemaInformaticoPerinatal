
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Modelo
{

    internal class DatosPerinatales
    {
        public int Id { get; set; }
        public string LugarControlPrenatal { get; set; }
        public string LugarPartoAborto { get; set; }
        public string NumeroDeIdentidad { get; set; }


      

    }
}
