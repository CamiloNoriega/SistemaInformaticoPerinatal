using Entidades;

namespace Repositorio
{
    internal class RepositorioMaestroEF: IRepositorioMaestro
    {
        private Modelo.DBGestionSistemaInformaticoP dBGestionSistemaInformaticoP;

        public RepositorioMaestroEF()
        {
            dBGestionSistemaInformaticoP = new Modelo.DBGestionSistemaInformaticoP();
        }


        public List<Etnia> ObtenerEtnia()
        {
            var etnia = dBGestionSistemaInformaticoP.Etina
                .Select(e => new Etnia() { Id = e.Id, Nombre = e.Nombre })
                .OrderBy(e => e.Nombre)
                .ToList();
            return etnia;
        }
        public List<EstadoCivil> ObtenerEstadoCivil()
        {
            var estadoCivil = dBGestionSistemaInformaticoP.EstadoCivil
                .Select(e => new EstadoCivil() { Id = e.Id, Nombre = e.Nombre })
                .OrderBy(e => e.Nombre)
                .ToList();
            return estadoCivil;
        }
        public List<NivelEstudios> ObtenerNivelEstudios()
        {
            var nivelEstudios = dBGestionSistemaInformaticoP.NivelEstudios
                .Select(e => new NivelEstudios() { Id = e.Id, Nombre = e.Nombre })
                .OrderBy(e => e.Nombre)
                .ToList();
            return nivelEstudios;
        }
        public List<UsoAnticonceptivos> ObtenerUsoAnticonseptivos()
        {
            var usoAntiConceptivo = dBGestionSistemaInformaticoP.UsoAnticonceptivos
                .Select(e => new UsoAnticonceptivos() { Id = e.Id, Nombre = e.Nombre })
                .OrderBy(e => e.Nombre)
                .ToList();
            return usoAntiConceptivo;
        }
    }
}
