using BarDoKBecao.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarDoKBecao.Dominio.Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testes_Soma_Pedido_com_2_itens()
        {
            Pedido pedido = new Pedido();
            Produto cerveja = new Produto() { Descricao = "Cerveja Lata 1L", Preco = 10 };
            Produto pizza = new Produto() { Descricao = "Pizza Calabresa Grande", Preco = 60 };

            pedido.ItemPedido.Add(new ItemPedido() { Quantidade = 10, Produto = cerveja });
            pedido.ItemPedido.Add(new ItemPedido() { Quantidade = 2, Produto = pizza });

            decimal valorPedido = pedido.ValorTotalPedido();

            Assert.AreEqual(valorPedido, 220);

        }

        [TestMethod]
        public void Testes_Soma_Pedido_com_2_itens_valores_errados()
        {
            Pedido pedido = new Pedido();
            Produto cerveja = new Produto() { Descricao = "Cerveja Lata 1L", Preco = 10 };
            Produto pizza = new Produto() { Descricao = "Pizza Calabresa Grande", Preco = 60 };

            pedido.ItemPedido.Add(new ItemPedido() { Quantidade = 10, Produto = cerveja });
            pedido.ItemPedido.Add(new ItemPedido() { Quantidade = 2, Produto = pizza });

            decimal valorPedido = pedido.ValorTotalPedido();
            Assert.AreEqual(valorPedido, 230);
        }

    }
}
