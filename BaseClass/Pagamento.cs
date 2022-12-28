using devPoo.Interfaces;
using System;

namespace devPoo.BaseClass
{
    public abstract class Pagamento : IPagamento, IDisposable
    {
        public DateTime Vencimento { get; set; }
        public double Valor { get; set; }

        public void Pagar(DateTime dataPagamento)
        {
            if (dataPagamento > Vencimento)
            {
                Console.WriteLine("Prazo para pagamento expirou!");
            }
            else
            {
                Console.WriteLine("Aguarde...processando pagamento.");
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
        }
    }
}
