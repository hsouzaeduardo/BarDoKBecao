using BarDoKBecao.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarDoKBecao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesaController : ControllerBase
    {
        [HttpGet]
        [Route("mesa/listar/{status}")]
        public IActionResult ListarMesas(int status)
        {
            return Ok(new Mesa());
        }
        [HttpPut]
        [Route("mesa/{id}")]
        public IActionResult AlterarMesas(int status)
        {
            return Ok(new Mesa());
        }
    }
}
