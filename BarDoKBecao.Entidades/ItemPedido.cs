namespace BarDoKBecao.Entidades
{
    public class ItemPedido : BaseEntity
    {
        public int Numero { get; set; }
        public short Quantidade { get; set; }
        public string Descricao { get; set; }
        public Produto Produto { get; set; }

    }
}