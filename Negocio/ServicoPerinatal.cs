using Entidades;
using Repositorio;
namespace Negocio
{
    public class ServicoPerinatal :IServicioPerinatal

    {
        private IRepositorioPerinatal repositorioPerinatal;

        public ServicoPerinatal(RepositorioPerinatal repositorioPerinatal)
        {
            this.repositorioPerinatal = repositorioPerinatal;
        }




        public void GuardarPaciente(Paciente Paciente)
        {
            repositorioPerinatal.GuardarPaciente(Paciente);
        }
        public void GuardarDatosPerinatales(DatosPerinatales datosPerinatales)
        {
            repositorioPerinatal.GuardarDatosPerinatales(datosPerinatales);
        }
        public void GuardarAntecedentesPersonales(AntecedentesPersonales antecedentesPersonales)
        {
            repositorioPerinatal.GuardarAntecedentesPersonales(antecedentesPersonales);
        }
        public void GuardarAntecedentesPObstetricos(AntecedentesPObstetricos antecedentesPObstetricos)
        {
            repositorioPerinatal.GuardarAntecedentesPObstetricos(antecedentesPObstetricos);
        }
        public void GuardarAntecedentesFamiliares(AntecedentesFamiliares antecedentesFamiliares)
        {
            repositorioPerinatal.GuardarAntecedentesFamiliares (antecedentesFamiliares);
        }
        public void GuardarEnfermedadesMaternas(EnfermedadesMaternas antecedentesMaternas)
        {
            repositorioPerinatal.GuardarEnfermedadesMaternas (antecedentesMaternas);
        }

    }
}
