using System.ComponentModel.DataAnnotations;

namespace GestionTareasApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
    }
}
