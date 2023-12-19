using Microsoft.EntityFrameworkCore;
using Sistema_gestion_mecanico.Models;

namespace Sistema_gestion_mecanico.Services
{
    public class EmpleadoService
    {
        private readonly GestionDbContext _context;
        public EmpleadoService(GestionDbContext context)
        {
            _context = context;
        }
        public async Task<List<Empleado>> GetEmpleados()
        {
            var resultado = await _context.Empleados.AsNoTracking().ToListAsync();
            return resultado;
        }
    }
}
