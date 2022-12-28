using System;
using System.Collections.Concurrent;
using System.Runtime;
using devPoo.Class.TipoPagamento;

public class Program
{
    public static void Main(string[] args)
    {
        using (var pagamentoBoleto = new Boleto())
        {
            Console.Clear();

            pagamentoBoleto.VerVencimento(new DateTime(2022, 5, 10));
            pagamentoBoleto.Pagar(DateTime.Now);
            pagamentoBoleto.CodigoDeBarras = "123456";

            Console.WriteLine(pagamentoBoleto.VerVencimento(DateTime.Now));
            Console.WriteLine(pagamentoBoleto.CodigoDeBarras);
        }
    }
}
