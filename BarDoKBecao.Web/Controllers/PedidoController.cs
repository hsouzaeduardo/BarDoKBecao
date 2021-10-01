using BarDoKBecao.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarDoKBecao.Web.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("produtos")]
        public IActionResult ConsultarProdutos()
        {
            return PartialView("_listagem-produtos", new List<Produto>());
        }

        [HttpPost]
        [Route("pedido")]
        public IActionResult GerarPedido()
        {
            return View();
        }

        [HttpGet("pedido/{numeroPedido}")]
        public IActionResult ConsultarPedido(Int64 numeroPedido) => StatusCode(200, new Pedido());

        [HttpPost("pedido/{numeroPedido}/item")]
        public IActionResult IncluirItemPedido(Int64 numeroPedido, [FromBody] List<ItemPedido> itemPedido) => StatusCode(200, new Pedido());

        [HttpDelete("pedido/{numeroPedido}/item/{codigoItem}")]
        public IActionResult RemoverItemPedido(Int64 numeroPedido, Int64 codigoItem) => StatusCode(200, new Pedido());

        [HttpGet("pedido/{numeroPedido}/listar")]
        public IActionResult ListarItensPedido(Int64 numeroPedido) => StatusCode(200, new Pedido());

        [HttpPatch("pedido/{numeroPedido}/item/{codigoItem}/{quantidade}")]
        public IActionResult AlterarQuantidadeItemPedido(Int64 numeroPedido, Int64 codigoItem, int quantidade) => StatusCode(200, new Pedido());

        [HttpPatch("conta/{numeroPedido}")]
        public IActionResult FecharContaNumero(Int64 numeroPedido) => StatusCode(200, new Pedido());
    }
}
