using Microsoft.EntityFrameworkCore;
using Sistema_gestion_mecanico.Models;
using Sistema_gestion_mecanico.Models.Dtos;
using Sistema_gestion_mecanico.Services.Interfaces;

namespace Sistema_gestion_mecanico.Services
{
    public class RectificadoService : IRectificadoService
    {
        private readonly GestionDbContext _context;
        public RectificadoService(GestionDbContext context)
        {
            _context = context;
        }

        public async Task<List<Rectificado>> GetRectificados()
        {
            var resultado = await _context.Rectificados.AsNoTracking()
                .Include(a => a.Pedidos)
                .ThenInclude(x => x.Proveedor)
                .Include(a => a.Pedidos)
                .ThenInclude(c => c.LineasDePedido)
                .ThenInclude(p => p.Insumo)
                .Include(a => a.Motores)
                .Include(a => a.Cliente)
                .Include(a => a.Operario)
                .Include(a => a.Estado)
                .ToListAsync();

            return resultado;
        }

        public async Task<Rectificado> AddRectificado(RectificadoDTO rectificado)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(c => c.Id == rectificado.ClienteID);
            Operario operario = _context.Operarios.FirstOrDefault(c => c.Id == rectificado.OperarioID);
            List<Motor> motores = rectificado.Motores;
            List<Pedido> pedidos = new List<Pedido>();
            DateTime fecha = DateTime.Now;
            Estado estado = _context.Estados.FirstOrDefault(c => c.Id == 1);


            Rectificado newRectificado = new Rectificado(cliente, operario, motores, pedidos, fecha, estado, 0, rectificado.ParaEnvio);


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
            var resultado = await _context.Clientes.Include(x=> x.Localidad).ThenInclude(x=> x.Provincia).ToListAsync();

            return resultado;
        }

        public async Task<bool> DeleteRectificado(int id)
        {
            var entity = _context.Rectificados
                .Include(a => a.Pedidos).ThenInclude(x => x.Proveedor)
                .Include(a => a.Pedidos).ThenInclude(c => c.LineasDePedido).ThenInclude(p => p.Insumo)
                .Include(a => a.Motores)
                .Include(a => a.Cliente)
                .Include(a => a.Operario)
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

        public async Task<bool> EditRectificado(int id, RectificadoUpdateDto updatedRectificado)
        {
            var entity = _context.Rectificados
               .Include(a => a.Pedidos).ThenInclude(x => x.Proveedor)
               .Include(a => a.Pedidos).ThenInclude(c => c.LineasDePedido).ThenInclude(p => p.Insumo)
               .Include(a => a.Motores)
               .Include(a => a.Cliente)
               .Include(a => a.Operario)
               .Include(a => a.Estado)
               .FirstOrDefault(c => c.Id == id);

            if (entity == null)
            {
                throw new KeyNotFoundException("Rectificado not found.");
            }

            // Use the Update method to set the properties
            entity.Update(updatedRectificado.Cliente, updatedRectificado.Operario, updatedRectificado.Motores, updatedRectificado.Estado, updatedRectificado.ParaEnvio);

            // Save changes to the database
            return await SaveChangesAsync();
        }
    }
}
