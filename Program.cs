using System;
using System.Collections.Concurrent;
using System.Runtime;
using devPoo.BaseClass;
using devPoo.Class.TipoPagamento;

public class Program
{
    public static void Main(string[] args)
    {
        using (var pagamentoBoleto = new Boleto())
        {
            pagamentoBoleto.Pagar();
            pagamentoBoleto.VerVencimento(DateTime.Now);
            pagamentoBoleto.CodigoDeBarras = "123456";

            Console.Clear();
            Console.WriteLine(pagamentoBoleto.VerVencimento(DateTime.Now));
            Console.WriteLine(pagamentoBoleto.CodigoDeBarras);
        }
    }
}
