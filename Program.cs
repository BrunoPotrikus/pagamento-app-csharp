using System;
using System.Collections.Concurrent;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
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

            var listaPagamentosBoleto = new List<Boleto>();
            listaPagamentosBoleto.Add(pagamentoBoleto);

            for (var index  = 0; index < listaPagamentosBoleto.Count; index++)
            {
                Console.WriteLine($"Boleto {index}: {listaPagamentosBoleto[index].Vencimento}");
            }

            // Buscando elemento(s) específico(s) dentro da lista
            var boletosPagos = listaPagamentosBoleto.Where(x => x.Vencimento <= DateTime.Now);

            // Verificando se elemneto existe na lista
            var exists = listaPagamentosBoleto.Any(x => x.CodigoDeBarras == "123457");

            // Removendo elemento da lista
            listaPagamentosBoleto.Remove(pagamentoBoleto);

            Console.WriteLine(pagamentoBoleto.VerVencimento(DateTime.Now));
            Console.WriteLine(pagamentoBoleto.CodigoDeBarras);
            Console.WriteLine(exists);
            Console.WriteLine(listaPagamentosBoleto.Count);
        }
    }
}
