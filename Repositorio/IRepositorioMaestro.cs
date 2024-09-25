using Entidades;

namespace Repositorio
{
    public interface IRepositorioMaestro
    {
        List<Etnia> ObtenerEtnia();
        List<EstadoCivil> ObtenerEstadoCivil();
        List<NivelEstudios> ObtenerNivelEstudios();
        List<UsoAnticonceptivos> ObtenerUsoAnticonseptivos();
    }
}
