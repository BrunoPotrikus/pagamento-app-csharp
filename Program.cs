using System;
using System.Collections.Concurrent;
using System.Runtime;

public class Program
{
    public static void Main(string[] args)
    {
        var pagamentoBoleto = new PagamentoBoleto();
        pagamentoBoleto.Pagar();
        pagamentoBoleto.VerVencimento(DateTime.Now);

        Console.Clear();
        Console.WriteLine(pagamentoBoleto.VerVencimento(DateTime.Now));
    }

    public class Pagamento
    {
        protected DateTime Vencimento;

        public virtual void Pagar()
        {
           
        }
    }

    internal class PagamentoBoleto : Pagamento
    {
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
