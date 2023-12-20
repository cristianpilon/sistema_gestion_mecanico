using Microsoft.EntityFrameworkCore;
using Sistema_gestion_mecanico.Models;
using Sistema_gestion_mecanico.Models.Dtos;
using Sistema_gestion_mecanico.Services.Interfaces;
using System.Linq;

namespace Sistema_gestion_mecanico.Services
{
    public class RectificadoService : IRectificadoService
    {
        private readonly GestionDbContext _context;
        public RectificadoService(GestionDbContext context)
        {
            _context = context;
        }

        public async Task<List<RectificadoResponseDTO>> GetRectificados(OperarioService operarioService)
        {
            var operarios = await operarioService.GetAsync();


            var resultado = await _context.Rectificados.AsNoTracking()
                .Include(a => a.Pedidos)
                .ThenInclude(x => x.Proveedor)
                .Include(a => a.Motores)
                .Include(a => a.Cliente)
                .Include(a => a.Estado)
                .ToListAsync();


            return resultado.Select(x =>
            {
                var operario = operarios.First(z => z.Id == x.OperarioId);
                return new RectificadoResponseDTO(x.Id, new Cliente(x.Cliente.Nombre, x.Cliente.Apellido, x.Cliente.Dni, x.Cliente.Direccion, x.Cliente.Localidad, x.Cliente.Email),
                       new Operario(operario.Nombre, operario.Apellido, operario.Dni, operario.Fecha), x.Motores, x.Fecha, x.Estado, x.Total, x.ParaEnvio);
            }).ToList();
        }

        public async Task<Rectificado> AddRectificado(RectificadoDTO rectificado)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(c => c.Id == rectificado.ClienteID);
            List<Motor> motores = rectificado.Motores;
            List<Pedido> pedidos = new List<Pedido>();
            DateTime fecha = DateTime.Now;
            Estado estado = _context.Estados.FirstOrDefault(c => c.Id == 1);


            Rectificado newRectificado = new Rectificado(cliente, rectificado.OperarioID, motores, pedidos, fecha, estado, 0, rectificado.ParaEnvio);


            _context.Rectificados.Add(newRectificado);
            await SaveChangesAsync();
            return newRectificado;
        }

        public async Task<List<Estado>> GetEstados()
        {
            var resultado = await _context.Estados.ToListAsync();

            return resultado;
        }
        public async Task<List<Proveedor>> GetProveedores()
        {
            var resultado = await _context.Proveedores.ToListAsync();

            return resultado;
        }
        public async Task<List<Operario>> GetOperarios()
        {
            var resultado = await _context.Operarios.ToListAsync();

            return resultado;
        }
        public async Task<List<Insumo>> GetInsumos()
        {
            var resultado = await _context.Insumos.ToListAsync();

            return resultado;
        }
        public async Task<List<Cliente>> GetClientes()
        {
            var resultado = await _context.Clientes.Include(x => x.Localidad).ThenInclude(x => x.Provincia).ToListAsync();

            return resultado;
        }

        public async Task<bool> DeleteRectificado(int id)
        {
            var entity = _context.Rectificados
                .Include(a => a.Pedidos).ThenInclude(x => x.Proveedor)
                .Include(a => a.Pedidos).ThenInclude(c => c.LineasDePedido).ThenInclude(p => p.Insumo)
                .Include(a => a.Motores)
                .Include(a => a.Cliente)
                .Include(a => a.Estado)
                .FirstOrDefault(c => c.Id == id);

            if (entity == null)
            {
                throw new KeyNotFoundException("Rectificado not found.");
            }

            _context.Rectificados.Remove(entity);
            return await SaveChangesAsync();
        }

        private async Task<bool> SaveChangesAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} ----- {e.InnerException}");
                throw;
            }
        }

        public async Task<bool> EditRectificado(string id, RectificadoUpdateDto updatedRectificado, OperarioService operarioService)
        {
            var cliente = await _context.Clientes.FirstAsync(c => c.Dni == updatedRectificado.ClienteId);
            var operario = await operarioService.GetAsync(updatedRectificado.OperarioId);
            var estado = await _context.Estados.FirstAsync(c => c.Id == updatedRectificado.EstadoId);


            var entity = _context.Rectificados
               .Include(a => a.Cliente)
               .Include(a => a.Estado)
               .FirstOrDefault(c => c.Id == Int32.Parse(id));

            if (entity == null)
            {
                throw new KeyNotFoundException("Rectificado not found.");
            }

            // Use the Update method to set the properties
            entity.Update(cliente, updatedRectificado.OperarioId, estado, updatedRectificado.ParaEnvio);

            // Save changes to the database
            return await SaveChangesAsync();
        }
    }
}
