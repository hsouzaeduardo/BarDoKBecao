using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarDoKBecao.Web.Models
{
    public class Mesa
    {
        public enum StatusMesa
        {
            Livre = 1,
            Ocupada = 2,
            Reservada = 3,
            Bloqueada = 99
        }
        [Required(ErrorMessage = "Número da Mesa Obrigatório")]
        [Display(Name = "Número da Mesa")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Manter primeiro Status como Livre")]
        public StatusMesa Status { get; set; }
        [Display(Name = "Data Hora abertura da Mesa")]
        public DateTime? DataAbertura { get; set; }
    }
}
