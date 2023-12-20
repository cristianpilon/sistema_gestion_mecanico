using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sistema_gestion_mecanico.Models;
using Sistema_gestion_mecanico.Models.Dtos;
using Sistema_gestion_mecanico.Services;
using Sistema_gestion_mecanico.Services.Interfaces;

namespace Sistema_gestion_mecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RectificadosController : ControllerBase
    {
        private readonly IRectificadoService _gestionService;
        private readonly OperarioService _operarioService;

        public RectificadosController(IRectificadoService gestionService, OperarioService operarioService)
        {
            _gestionService = gestionService;
            _operarioService = operarioService;
        }

        // GET: api/Rectificados
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<RectificadoResponseDTO>>> GetRectificados()
        {
            var resultado = await _gestionService.GetRectificados(_operarioService);
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }
        
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<IEnumerable<RectificadoDTO>>> AddRectificado(RectificadoDTO rectificado)
        {
            var resultado = await _gestionService.AddRectificado(rectificado);
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<RectificadoDTO>>> DeleteRectificado(int id)
        {
            var resultado = await _gestionService.DeleteRectificado(id);
            if (!resultado)
            {
                return NotFound();
            }
            return Ok(resultado);
        }

        // PUT: api/Rectificados/{id}
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutRectificado(string id, [FromBody] RectificadoUpdateDto updateDto)
        {
            try
            {
                var success = await _gestionService.EditRectificado(id, updateDto, _operarioService);
                if (success)
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (log it, etc.)
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
