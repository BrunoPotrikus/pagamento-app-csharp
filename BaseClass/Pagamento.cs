using devPoo.Interfaces;
using System;

namespace devPoo.BaseClass
{
    public class Pagamento : IPagamento, IDisposable
    {
        public DateTime Vencimento { get; set; }
        public double Valor { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
        }

        public virtual void Pagar()
        {

        }
    }
}
