using System;
using devPoo.BaseClass;

namespace devPoo.Class.TipoPagamento
{
    public class Boleto : Pagamento
    {
        public int ValorBoleto { get; set; }

        private string _codigoDeBarras;

        public string CodigoDeBarras
        {
            get { return _codigoDeBarras; }
            set { _codigoDeBarras = value; }
        }

        public override void Pagar()
        {
            base.Pagar();
        }

        public DateTime VerVencimento(DateTime vencimento)
        {
            base.Vencimento = vencimento;
            return base.Vencimento;
        }
    }
}
