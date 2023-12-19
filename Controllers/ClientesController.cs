using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_gestion_mecanico.Models;
using Sistema_gestion_mecanico.Services;
using Sistema_gestion_mecanico.Services.Interfaces;

namespace Sistema_gestion_mecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IRectificadoService _gestionService;

        public ClientesController(IRectificadoService gestionService)
        {
            _gestionService = gestionService;
        }

        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            var resultado = await _gestionService.GetClientes();
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok(resultado);
        }

    }
}
