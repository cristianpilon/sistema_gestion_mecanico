using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_gestion_mecanico.Models;
using Sistema_gestion_mecanico.Services.Interfaces;

namespace Sistema_gestion_mecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperariosController : ControllerBase
    {
        private readonly IRectificadoService _gestionService;
        public OperariosController(IRectificadoService gestionService)
        {
            _gestionService = gestionService;
        }

        // GET: api/Estados
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Estado>>> GetOperarios()
        {
            var resultado = await _gestionService.GetOperarios();
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }
    }
}
