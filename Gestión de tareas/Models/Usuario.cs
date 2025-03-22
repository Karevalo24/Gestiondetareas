using System.ComponentModel.DataAnnotations;

namespace Gestión_de_tareas.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Correo { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Contraseña { get; set; } = string.Empty; // Contraseña para login

    }
}
