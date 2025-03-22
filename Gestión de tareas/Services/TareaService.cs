using GestionTareasApp.Data;
using GestionTareasApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GestorTareasBlazor.Services
{
    public class TareaService
    {
        private readonly GestionTareasContext _context;

        public TareaService(GestionTareasContext context)
        {
            _context = context;
        }

        public async Task<List<Tarea>> ObtenerTareasAsync()
        {
            return await _context.Tareas.ToListAsync();
        }

        public async Task AgregarTareaAsync(Tarea tarea)
        {
            _context.Tareas.Add(tarea);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarTareaAsync(Tarea tarea)
        {
            _context.Tareas.Update(tarea);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarTareaAsync(int id)
        {
            var tarea = await _context.Tareas.FindAsync(id);
            if (tarea != null)
            {
                _context.Tareas.Remove(tarea);
                await _context.SaveChangesAsync();
            }
        }
    }
}
