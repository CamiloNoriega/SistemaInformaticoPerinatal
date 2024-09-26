
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Modelo
{
    [Table("DatosPerinatales")]
    public class DatosPerinatales
    {
        [Key]
        public int Id { get; set; }
        public string LugarControlPrenatal { get; set; }
        public string LugarPartoAborto { get; set; }
        public string NumeroDeIdentidad { get; set; }
        public int IdPaciente { get; set; }
        public virtual Paciente Paciente { get; set; }




    }
}
