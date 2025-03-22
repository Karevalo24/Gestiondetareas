using Gestión_de_tareas.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace GestionTareasApp.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(100)]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        public string Descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "La fecha límite es obligatoria.")]
        public DateTime FechaLimite { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio.")]
        [StringLength(10)]
        public string Estado { get; set; } = string.Empty; // "Pendiente" o "Completa"

        [Required(ErrorMessage = "La prioridad es obligatoria.")]
        public int Prioridad { get; set; } = 1; // Prioridad por defecto

        public bool Activo { get; set; } = true;

        public int UsuarioId { get; set; } // Relación con Usuario
        public Usuario Usuario { get; set; } // Propiedad de navegación
    }
}
