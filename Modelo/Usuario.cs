

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        

        
    }
}
