using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_gestion_mecanico.Models;
using Sistema_gestion_mecanico.Services;
using Sistema_gestion_mecanico.Services.Interfaces;

namespace Sistema_gestion_mecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosController : ControllerBase
    {
        private readonly IRectificadoService _gestionService;
        public EstadosController(IRectificadoService gestionService)
        {
            _gestionService = gestionService;
        }

        // GET: api/Estados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estado>>> GetEstados()
        {
            var resultado = await _gestionService.GetEstados();
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }
    }
}
