using devPoo.Class.TipoPessoa;
using devPoo.Interfaces;

namespace devPoo.BaseClass
{
    internal class Venda<TP, PG> : IVenda<TP, PG>
    {
        public Venda(Vendedor vendedor, Cliente cliente, TP produto, PG pagamento) 
        {
            Vendedor= vendedor;
            Cliente= cliente;
            Produto= produto;
            Pagamento= pagamento;
        }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public TP Produto { get; set; }
        public PG Pagamento { get; set; }
    }
}
