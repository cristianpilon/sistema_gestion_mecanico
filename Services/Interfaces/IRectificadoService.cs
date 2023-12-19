    using Microsoft.AspNetCore.Mvc;
using Sistema_gestion_mecanico.Models;
using Sistema_gestion_mecanico.Models.Dtos;

namespace Sistema_gestion_mecanico.Services.Interfaces
{
    public interface IRectificadoService
    {
        Task<List<Rectificado>> GetRectificados();
        Task<Rectificado> AddRectificado(RectificadoDTO rectificado);
        Task<bool> DeleteRectificado(int id);
        Task<bool> EditRectificado(int id, RectificadoUpdateDto updatedRectficado);
        Task<List<Cliente>> GetClientes();
        Task<List<Operario>> GetOperarios();
        Task<List<Estado>> GetEstados();

    }
}
