using BarDoKBecao.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarDoKBecao.Web.Controllers
{
    public class ClienteController : Controller
    {
        [Route("/cliente/novo")]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        [Route("cliente/novo")]
        public IActionResult Cadastro([FromForm] Cliente cliente)
        {
            return View();
        }

        [Route("/cliente/buscar/{cpf}")] //:regex(^\\d{{3}}.d{{3}}.d{{3}}-d{{3}})$}")]
        public IActionResult Cadastro(Int64 cpf)
        {
            return View();
        }


    }
}
