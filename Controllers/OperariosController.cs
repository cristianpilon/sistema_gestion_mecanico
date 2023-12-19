using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sistema_gestion_mecanico.Models.MongoDb;
using Sistema_gestion_mecanico.Services;

namespace Sistema_gestion_mecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperariosController : ControllerBase
    {
        private readonly OperarioService _operarioService;
        public OperariosController(OperarioService operarioService)
        {
            _operarioService = operarioService;
        }

        // GET: api/Operarios
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Operario>>> GetOperarios()
        {
            var resultado = await _operarioService.GetAsync();
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }
    }
}
