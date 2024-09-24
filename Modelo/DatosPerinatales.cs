﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Modelo
{
    [Table("DatosPerinatales")]
    internal class DatosPerinatales
    {
        [Key]
        public int Id { get; set; }
        public string LugarControlPrenatal { get; set; }
        public string LugarPartoAborto { get; set; }
        public string NumeroDeIdentidad { get; set; }

        public virtual ICollection<Paciente> Paciente { get; set; }




    }
}
