using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BarDoKBecao.Entidades
{
    public enum FormaPagamento
    {
        Credito = 1,
        Debito = 2,
        VR = 3,
        Dinheiro = 4,
        Pix = 5
    }

    public enum StatusPedido
    {
        Aguardando = 1,
        Entregue = 2,
        Encerrado = 3,
        Pago = 4
    }

    public class Pedido : BaseEntity
    {
        public Pedido()
        {
            ItemPedido = new List<ItemPedido>();
        }

        public FormaPagamento FormaPagamento { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> ItemPedido { get; set; }
        public Mesa Mesa { get; set; }
        public StatusPedido StatusPedido { get; set; }

        public void PagarPedido()
        {
            StatusPedido = StatusPedido.Pago;
        }
        //public void IncluirItemPedido(ItemPedido item)
        //{
        //    ItemPedido.Add(item);
        //}

        //public void ExcluirItemPedido(Guid item)
        //{
        //    var itemSelected = ItemPedido.FirstOrDefault(x=> x.Id == item);

        //    if(itemSelected != null)
        //    {
        //        itemSelected.Desativar();
        //    }
        //}

        public decimal ValorTotalPedido()
        {
            return ItemPedido.Sum(x=> x.Quantidade * x.Produto.Preco); 
        }

    }
}
