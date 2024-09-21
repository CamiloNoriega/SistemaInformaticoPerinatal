﻿

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
        public string Etnia { get; set; }// crear entidad
        

        public bool Alfabeta { get; set; }
        public string NivelEstudios { get; set; }// crear entidad
        public string AñoAprobado { get; set; }
        public string EstadoCivil { get; set; }// crear entidad
        public bool ViveSola { get; set; }
    }
}