

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
        public int Edad { get; set; }
        public string Etnia { get; set; }
        public bool Alfabeta { get; set; }
        public string NivelDeEstudios { get; set; }
        public int AñoAprobado { get; set; }
        public string EstadoCivil { get; set; }
        public bool ViveSola { get; set; }
    }
}