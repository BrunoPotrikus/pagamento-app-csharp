using devPoo.Class.TipoPessoa;
using devPoo.Interfaces;

namespace devPoo.BaseClass
{
    public sealed class Venda
    {
        public Venda(Vendedor vendedor, Cliente cliente, Produto novoProduto, Pagamento novoPagamento)
        {
            Vendedor = vendedor;
            Cliente = cliente;
            NovoProduto = novoProduto;
            NovoPagamento = novoPagamento;
        }

        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public Produto NovoProduto { get; set; }
        public Pagamento NovoPagamento { get; set; }
    }
}
