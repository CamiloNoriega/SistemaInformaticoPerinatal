using Entidades;

namespace Repositorio
{
    public interface IRepositorioPerinatal
    {
        public void GuardarPaciente(Paciente paciente);
        public void GuardarDatosPerinatales(DatosPerinatales datosPerinatales);
        public void GuardarAntecedentesPersonales(AntecedentesPersonales antecedentesPersonales);
        public void GuardarAntecedentesPObstetricos(AntecedentesPObstetricos antecedentesPObstetricos);
        public void GuardarAntecedentesFamiliares(AntecedentesFamiliares antecedentesFamiliares);
        public void GuardarEnfermedadesMaternas(EnfermedadesMaternas antecedentesMaternas);
    }
}
