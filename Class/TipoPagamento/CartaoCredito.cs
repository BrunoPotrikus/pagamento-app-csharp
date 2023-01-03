using devPoo.BaseClass;

namespace devPoo.Class.TipoPagamento
{
    public class CartaoCredito : Pagamento
    {
        public CartaoCredito(int qantidadeParcelas) 
        {
            QuantidadeParcelas= qantidadeParcelas;
        }
        public int QuantidadeParcelas { get; set; }
        public void ConsultaLimite()
        {
            
        }
    }
}
