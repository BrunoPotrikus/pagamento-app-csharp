using System;
using System.Collections.Concurrent;
using System.Runtime;

public class Program
{
    public static void Main(string[] args)
    {
        var pagamentoBoleto = new PagamentoBoleto();
        pagamentoBoleto.Pagar();
        pagamentoBoleto.Vencimento = DateTime.Now;

        Console.Clear();
        Console.WriteLine(pagamentoBoleto.Vencimento);
    }

    class Pagamento
    {
        public DateTime Vencimento;

        public void Pagar()
        {
           
        }
    }

    class PagamentoBoleto : Pagamento
    {

    }
}
