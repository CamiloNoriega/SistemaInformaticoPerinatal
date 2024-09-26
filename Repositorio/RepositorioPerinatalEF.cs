using Entidades;


namespace Repositorio
{
    public class RepositorioPerinatalEF : IRepositorioPerinatal
    {
        private Modelo.DBGestionSistemaInformaticoP dBGestionSistemaInformaticoP;

        public RepositorioPerinatalEF()
        {
            dBGestionSistemaInformaticoP = new Modelo.DBGestionSistemaInformaticoP();
        }

        public void GuardarPaciente(Paciente paciente) 
        { 
            var pacienteActual = dBGestionSistemaInformaticoP..FirstOrDefault(p => p.IdTipoDocumento == evaluacion.Persona.TipoDocumento.Id &&
            p.NumeroDocumento == evaluacion.Persona.NumeroDocumento);
        }
        public void GuardarDatosPerinatales(DatosPerinatales datosPerinatales);
        public void GuardarAntecedentesPersonales(AntecedentesPersonales antecedentesPersonales);
        public void GuardarAntecedentesPObstetricos(AntecedentesPObstetricos antecedentesPObstetricos);
        public void GuardarAntecedentesFamiliares(AntecedentesFamiliares antecedentesFamiliares);
        public void GuardarEnfermedadesMaternas(EnfermedadesMaternas antecedentesMaternas);


    }
}
