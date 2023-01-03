using devPoo.BaseClass;
using devPoo.Class.TipoPessoa;

namespace devPoo.Interfaces
{
    public interface IVenda
    { 
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public Produto NovoProduto { get; set; }
        public Pagamento NovoPagamento { get; set; }
    }
}
