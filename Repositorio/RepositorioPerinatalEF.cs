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

        }
        public void GuardarDatosPerinatales(DatosPerinatales datosPerinatales)
        {
            var personaActual = dBGestionSistemaInformaticoP.Usuario.FirstOrDefault();

        }
        
        public void GuardarAntecedentesPersonales(AntecedentesPersonales antecedentesPersonales)
        {

        }
        public void GuardarAntecedentesPObstetricos(AntecedentesPObstetricos antecedentesPObstetricos)
        {

        }
        public void GuardarAntecedentesFamiliares(AntecedentesFamiliares antecedentesFamiliares)
        {

        }
        public void GuardarEnfermedadesMaternas(EnfermedadesMaternas antecedentesMaternas)
        {

        }


    }
}
