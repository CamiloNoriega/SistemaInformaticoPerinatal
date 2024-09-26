using Entidades;
namespace Repositorio
{
    public class RepositorioSeguridadEF : IRepositorioSeguridad
    {
        private Modelo.DBGestionSistemaInformaticoP dbGestionSistemaInformaticoP;

        public RepositorioSeguridadEF()
        {
            dbGestionSistemaInformaticoP = new Modelo.DBGestionSistemaInformaticoP();
        }

        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            var usuarioActual = dbGestionSistemaInformaticoP.Usuario.FirstOrDefault(u=>u.NombreUsuario == nombreUsuario);

            if (usuarioActual != null)
            {
                return new Usuario() { NombreUsuario = usuarioActual.NombreUsuario, Clave = usuarioActual.Clave };
            }

            return null;
        }
    }
}
