using GestionTareasApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionTareasApp.Data
{
    public class GestionTareasContext : DbContext
    {
        public GestionTareasContext(DbContextOptions<GestionTareasContext> options)
            : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }

        // Si en el futuro agregas más entidades, decláralas aquí.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración adicional: se establece que el campo "Estado" es requerido y tiene un máximo de 10 caracteres.
            modelBuilder.Entity<Tarea>()
                .Property(t => t.Estado)
                .HasMaxLength(10)
                .IsRequired();

            // Se pueden agregar configuraciones adicionales según sea necesario.
            base.OnModelCreating(modelBuilder);
        }
    }
}
