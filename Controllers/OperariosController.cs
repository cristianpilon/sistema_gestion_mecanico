using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sistema_gestion_mecanico.Models.Dtos;
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

        // GET: api/Operarios/{id}
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Operario>>> GetOperario(string id)
        {
            var resultado = await _operarioService.GetAsync(id);
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }

        // POST: api/Operarios
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<IEnumerable<RectificadoDTO>>> AddOperario(OperarioDTO operario)
        {
            await _operarioService.CreateAsync(operario);
            return Ok();
        }

        // PUT: api/Operarios/{id}
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutOperario(string id, [FromBody] Operario operario)
        {
            var resultado = await _operarioService.GetAsync(id);
            if (resultado == null)
            {
                return NotFound();
            }

            await _operarioService.UpdateAsync(id, operario);
            return Ok();
        }

        // DELETE: api/Operarios/{id}
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<RectificadoDTO>>> DeleteOperario(string id)
        {
            var resultado = await _operarioService.GetAsync(id);
            if (resultado == null)
            {
                return NotFound();
            }

            await _operarioService.RemoveAsync(id);
            
            return Ok();
        }
    }
}
