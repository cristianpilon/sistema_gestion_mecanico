using Microsoft.EntityFrameworkCore;
using Sistema_gestion_mecanico.Models;
using Sistema_gestion_mecanico.Models.Dtos;

namespace Sistema_gestion_mecanico.Services
{
    public class ClienteService
    {
        private readonly GestionDbContext _context;
        public ClienteService(GestionDbContext context)
        {
            _context = context;
        }
        public async Task<List<Cliente>> GetRectificados()
        {
            var resultado = await _context.Clientes.AsNoTracking()
                .ToListAsync();
            return resultado;
        }

    }
}
