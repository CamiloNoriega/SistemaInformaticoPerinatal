using Entidades;
using Repositorio;

namespace Negocio
{
    public class ServicioMaestro :IServicioMaestro
    {
        private IRepositorioMaestro repositorioMaestro;

        public ServicioMaestro(RepositorioMaestro repositorioMaestro)
        {
            this.repositorioMaestro = repositorioMaestro;
        }
        public ServicioMaestro()
        {
            repositorioMaestro = new RepositorioMaestroEF();
        }

        public List<Etnia> ObtenerEtnia()
        => repositorioMaestro.ObtenerEtnia();
        public List<EstadoCivil> ObtenerEstadoCivil()
        => repositorioMaestro.ObtenerEstadoCivil();
        public List<NivelEstudios> ObtenerNivleEstudios()
        => repositorioMaestro.ObtenerNivelEstudios();
        public List<UsoAnticonceptivos> ObtenerUsoAnticonseptivos()
        => repositorioMaestro.ObtenerUsoAnticonseptivos();

    }
    
}
