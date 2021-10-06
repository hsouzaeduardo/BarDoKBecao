using BarDoKBecao.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarDoKBecao.Infra.Repositorio
{
    public class RepoPedido : RepoSQLDB<Pedido>, IRepoPedido
    {
        
        public RepoPedido(Contexto.Contexto ctx):base(ctx)
        {

        }

        public Pedido ListPedidoByItem(Guid id)
        {
            //SELECT * from pEDIDO a INNER JOIN ITEMPEDIDO B 
            //    ON A.ID = B.IDPEDIDO
            //    INNER JOIN pRODUTO C
            //    ON B.ID = C.ITEMPEDIDOID
            //WHERE A.ID = ID

            return base._tabelas
                .Include(x => x.ItemPedido)
                .ThenInclude(x => x.Produto).FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
