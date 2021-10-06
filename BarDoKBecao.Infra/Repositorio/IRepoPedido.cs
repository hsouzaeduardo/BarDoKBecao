using BarDoKBecao.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BarDoKBecao.Infra.Repositorio
{
    public interface IRepoPedido : IRepo<Pedido>
    {
        Pedido ListPedidoByItem(Guid id);

    }
}
