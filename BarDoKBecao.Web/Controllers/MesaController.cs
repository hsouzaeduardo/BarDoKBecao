using BarDoKBecao.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarDoKBecao.Web.Controllers
{
    public class MesaController : Controller
    {
        public static IList<Mesa> _mesas = new List<Mesa>();

        public MesaController()
        {
            if (_mesas.Count.Equals(0))
            {
                _mesas.Add(new Mesa() { Numero = 1, Status = Mesa.StatusMesa.Livre });
                _mesas.Add(new Mesa() { Numero = 2, Status = Mesa.StatusMesa.Ocupada, DataAbertura = DateTime.Now.AddMinutes(-10) });
                _mesas.Add(new Mesa() { Numero = 3, Status = Mesa.StatusMesa.Reservada });
            }
        }

        public IActionResult Index()
        {
            return View(_mesas);
            //return View();
        }

        public IActionResult Edit(int id)
        {
            var mesa = _mesas.FirstOrDefault(x => x.Numero.Equals(id));

            return View(mesa);
        }
        [HttpPost]
        public IActionResult Edit([FromForm] Mesa mesa)
        {
            var mesaSeleciona = _mesas.FirstOrDefault(x => x.Numero.Equals(mesa.Numero));
            mesaSeleciona.Status = Mesa.StatusMesa.Reservada;
            mesaSeleciona.DataAbertura = mesa.DataAbertura;

            return RedirectToAction("Index");
        }

        public IActionResult Nova()
        {
            return View(new Mesa() {Status = Mesa.StatusMesa.Livre });
        }

        [HttpPost]
        public IActionResult Nova([FromForm] Mesa mesaNova)
        {
            _mesas.Add(mesaNova);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("mesa/listar/{status}")]
        public IActionResult ListarMesas(int status)
        {
            Mesa.StatusMesa statusMesa = (Mesa.StatusMesa)status;

            var result = _mesas.Where(x => x.Status.Equals(statusMesa));

            return Ok(result);
        }
    }
}
