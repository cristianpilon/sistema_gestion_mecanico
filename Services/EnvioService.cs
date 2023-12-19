using Microsoft.EntityFrameworkCore;
using Sistema_gestion_mecanico.Models;
using Sistema_gestion_mecanico.Models.Dtos;

namespace Sistema_gestion_mecanico.Services
{
    public class EnvioService
    {
        private readonly GestionDbContext _context;
        public EnvioService(GestionDbContext context)
        {
            _context = context;
        }

        public async Task<List<Envio>> GetEnvios()
        {
            var resultado = await _context.Envios
                .AsNoTracking()
                .Include(a => a.Rectificado)
                .ThenInclude(x => x.Cliente)
                .Include(a => a.Transportista)
                .ToListAsync();

            return resultado;
        }
        public async Task<Envio> AddEnvio(Rectificado rectificado)
        {
            // creo el envio con el primer estado, que seria pendiente
            Envio newEnvio = new Envio(rectificado, _context.EstadoEnvios.First());

            _context.Envios.Add(newEnvio);
            await _context.SaveChangesAsync();
            return newEnvio;
        }
        public async Task<Envio> ModifyEnvio(ModifyEnvioDTO modifyEnvioDTO)
        {
            try
            {
                var entity = _context.Envios.FirstOrDefault(c => c.Id == modifyEnvioDTO.EnvioId);
                if (entity == null)
                {
                    throw new KeyNotFoundException("Envio not found.");
                }

                if (entity.EstadoEnvio.Descripcion == "Enviado")
                {
                    throw new KeyNotFoundException("No se puede modificar envio ya que ya fue enviado");
                }
                var estadoEnvio = _context.EstadoEnvios.FirstOrDefault(c => c.Id == modifyEnvioDTO.EnvioId);
                var transportista = _context.Transportistas.FirstOrDefault(c => c.Id == modifyEnvioDTO.TransportistaId);

                if (estadoEnvio == null || transportista == null)
                {
                    throw new ArgumentException("Invalid estadoEnvio or transportista.");
                }

                entity.setEstadoYFecha(estadoEnvio, DateTime.Now, transportista);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception e )
            {
                Console.WriteLine($"{e.Message} ----- {e.InnerException}");
                throw ;
            }
        }

    }
}
