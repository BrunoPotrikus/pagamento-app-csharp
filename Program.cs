using System;
using System.Collections.Concurrent;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using devPoo.BaseClass;
using devPoo.Class.TipoPagamento;
using devPoo.Class.TipoPessoa;
using devPoo.Class.TipoProduto;

public class Program
{
    public static void Main(string[] args)
    {
        //var pagamentoBoleto = new Boleto();
        //Console.Clear();

        //pagamentoBoleto.VerVencimento(new DateTime(2022, 5, 10));
        //pagamentoBoleto.Pagar(DateTime.Now);
        //pagamentoBoleto.CodigoDeBarras = "123456";

        //var listaPagamentosBoleto = new List<Boleto>();
        //listaPagamentosBoleto.Add(pagamentoBoleto);

        //for (var index = 0; index < listaPagamentosBoleto.Count; index++)
        //{
        //    Console.WriteLine($"Boleto {index}: {listaPagamentosBoleto[index].Vencimento}");
        //}

        //// Buscando elemento(s) específico(s) dentro da lista
        //var boletosPagos = listaPagamentosBoleto.Where(x => x.Vencimento <= DateTime.Now);

        //// Verificando se elemneto existe na lista
        //var exists = listaPagamentosBoleto.Any(x => x.CodigoDeBarras == "123457");

        //// Removendo elemento da lista
        //listaPagamentosBoleto.Remove(pagamentoBoleto);

        //// Pegando e pulando quantidade específica de itens da lista
        //foreach (var item in listaPagamentosBoleto.Skip(1).Take(3))
        //{
        //    Console.WriteLine($"Sub lista: {item.CodigoDeBarras}");
        //}

        //// Convertendo listas
        //IEnumerable<Boleto> novaListaPagamentosBoleto = new List<Boleto>();
        //novaListaPagamentosBoleto.ToList();

        //// Convertendo para Enumerable
        //var enumerableLista = novaListaPagamentosBoleto.AsEnumerable();

        //// Convertendo para array
        //var novalistaArray = novaListaPagamentosBoleto.ToArray();

        //Console.WriteLine(pagamentoBoleto.VerVencimento(DateTime.Now));
        //Console.WriteLine(pagamentoBoleto.CodigoDeBarras);
        //Console.WriteLine(exists);
        //Console.WriteLine(listaPagamentosBoleto.Count);
        Console.Clear();
        var cliente = new Cliente("Bruno");
        var vendedor = new Vendedor("José");
        var produto = new Notebook(
                "G-15",
                "Gamer",
                9649.00,
                "Dell",
                "AMD Ryzen 7 5800H",
                "16GB DDR5",
                "512GB SSD",
                "NVIDIA GeForce® RTX 3060 6GB GDDR6"
            );

        var pagamento = new CartaoCredito(10);
        var venda = new Venda<Notebook, CartaoCredito>(vendedor, cliente, produto, pagamento);
        Console.WriteLine(venda.Cliente.Nome);
        Console.WriteLine($"{venda.Produto.Marca} {venda.Produto.Nome}");
        Console.WriteLine(venda.Pagamento.Valor);
        Console.WriteLine(venda.Vendedor.Nome);
    }
}
