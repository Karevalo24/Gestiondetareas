using System.ComponentModel.DataAnnotations;

namespace Gestión_de_tareas.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
    }
}
