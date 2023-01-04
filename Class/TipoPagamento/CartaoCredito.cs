using devPoo.BaseClass;

namespace devPoo.Class.TipoPagamento
{
    public class CartaoCredito : Pagamento
    {

        public CartaoCredito() 
        {
            ConsultaLimite();

            if (QuantidadeParcelas > 1)
            {
                var valorParcelas = ParcelarCompra(Valor, QuantidadeParcelas);
                Console.WriteLine($"Valor das parcelas: {valorParcelas}");
            }
            else
            {
                Console.WriteLine("À vista");
            }
        }
        public int QuantidadeParcelas { get; set; }

        public void ConsultaLimite()
        {
            
        }

        public double ParcelarCompra(double valor, int parcelas)
        {
            var valorParcela = valor / parcelas;
            return valorParcela;
        }
    }
}
