using Microsoft.AspNetCore.Mvc;
using Sistema_gestion_mecanico.Models;
using Sistema_gestion_mecanico.Models.Dtos;

namespace Sistema_gestion_mecanico.Services.Interfaces
{
    public interface IRectificadoService
    {
        Task<List<RectificadoResponseDTO>> GetRectificados(OperarioService operarioService);
        Task<Rectificado> AddRectificado(RectificadoDTO rectificado);
        Task<bool> DeleteRectificado(int id);
        Task<bool> EditRectificado(string id, RectificadoUpdateDto updatedRectficado, OperarioService _operarioService);
        Task<List<Cliente>> GetClientes();
        Task<List<Operario>> GetOperarios();
        Task<List<Estado>> GetEstados();

    }
}
