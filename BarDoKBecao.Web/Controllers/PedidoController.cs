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
    }
}
