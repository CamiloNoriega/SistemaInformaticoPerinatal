using Entidades;


namespace Repositorio
{
    public class RepositorioMaestro :IRepositorioMaestro
    {
        public List<Etnia> ObtenerEtnia()
        {
            var Etnia = new List<Etnia>();
            Etnia.Add(new Etnia() { Id = 1, Nombre = "Blanca" });
            Etnia.Add(new Etnia() { Id = 2, Nombre = "Negra" });
            Etnia.Add(new Etnia() { Id = 3, Nombre = "Indigena" });
            Etnia.Add(new Etnia() { Id = 4, Nombre = "Mestiza" });
            Etnia.Add(new Etnia() { Id = 5, Nombre = "Otros" });

            return Etnia;
        }

        public List<EstadoCivil> ObtenerEstadoCivil() 
        {
            var EstadoCivil = new List<EstadoCivil>();
            EstadoCivil.Add(new EstadoCivil() { Id = 1, Nombre = "Soltera" });
            EstadoCivil.Add(new EstadoCivil() { Id = 2, Nombre = "Casada" });
            EstadoCivil.Add(new EstadoCivil() { Id = 3, Nombre = "Union Libre" });
            EstadoCivil.Add(new EstadoCivil() { Id = 4, Nombre = "Otro" });

            return EstadoCivil;
        }

        public List<NivelEstudios> ObtenerNivelEstudios()
        {
            var NivelEstudios = new List<NivelEstudios>();
            NivelEstudios.Add(new NivelEstudios() { Id = 1, Nombre = "Primaria" });
            NivelEstudios.Add(new NivelEstudios() { Id = 2, Nombre = "Secundaria" });
            NivelEstudios.Add(new NivelEstudios() { Id = 3, Nombre = "Universidad" });
            NivelEstudios.Add(new NivelEstudios() { Id = 4, Nombre = "Ninguno" });

            return NivelEstudios;
        }

        public List<UsoAnticonceptivos> ObtenerUsoAnticonseptivos()
        {
            var UsoAnticonceptivos = new List<UsoAnticonceptivos>();
            UsoAnticonceptivos.Add(new UsoAnticonceptivos() { Id = 1, Nombre = "No uasaba" });
            UsoAnticonceptivos.Add(new UsoAnticonceptivos() { Id = 2, Nombre = "Barrera" });
            UsoAnticonceptivos.Add(new UsoAnticonceptivos() { Id = 3, Nombre = "Hormonal" });
            UsoAnticonceptivos.Add(new UsoAnticonceptivos() { Id = 4, Nombre = "DIU" });
            UsoAnticonceptivos.Add(new UsoAnticonceptivos() { Id = 5, Nombre = "Natural" });

            return UsoAnticonceptivos;
        }
    }
 
}
