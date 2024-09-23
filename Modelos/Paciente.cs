

using Entidades.Enumeraciones;

namespace Entidades
{

    public class Paciente
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Localidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public  Etnia Etnia { get; set; }// crear entidad
        

        public bool Alfabeta { get; set; }
        

        public  NivelEstudios NivelEstudios { get; set; }// crear entidad
        public string AñoAprobado { get; set; }
        public  EstadoCivil EstadoCivil{ get; set; }// crear entidad


        public bool ViveSola { get; set; }
       
    }
}