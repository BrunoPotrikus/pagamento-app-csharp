using devPoo.BaseClass;
using devPoo.Class.TipoPessoa;
using devPoo.Class.TipoProduto;

namespace devPoo.Eventos
{
    public class VenderProduto
    {
        public static DateTime DiaHoraVenda { get; set; }

        public static void Vender(Produto produto, Cliente cliente, Vendedor vendedor, Pagamento pagamento)
        {
            var venda = new Venda(vendedor, cliente, produto, pagamento);
            Console.WriteLine($"Venda realizada em {DiaHoraVenda:D}");
            Console.WriteLine($"Cliente: {venda.Cliente.Nome}");
            Console.WriteLine($"Vendedor: {venda.Vendedor.Nome}");

            //String especificacoes = "";
            //if(produto is Notebook)
            //{
            //    Notebook n = (Notebook)produto;
            //    especificacoes += n.
            //}

            // Console.WriteLine($"Produto: {venda.NovoProduto.GetPropriedadesEspecificas(produto.GetType)}");
            Console.WriteLine($"Especificações: {produto.GetType().Name}");
            Console.WriteLine($"Processador: {venda.NovoProduto}");
        }
    }
}
