using devPoo.BaseClass;
using devPoo.Class.TipoPessoa;

namespace devPoo.Interfaces
{
    public interface IVenda<TP, PG>
    {
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public TP Produto { get; set; }
        public PG Pagamento { get; set; }
    }
}
