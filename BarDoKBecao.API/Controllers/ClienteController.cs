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
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        [Route("cliente/novo")]
        public IActionResult Cadastro([FromBody] Cliente cliente)
        {
            return StatusCode(201, new Cliente());
        }

        [HttpGet]
        [Route("cliente/buscar/{cpf}")] //:regex(^\\d{{3}}.d{{3}}.d{{3}}-d{{3}})$}")]
        public IActionResult Cadastro(Int64 cpf)
        {
            return Ok(new Cliente());
        }
    }
}
