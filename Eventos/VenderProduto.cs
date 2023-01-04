using devPoo.BaseClass;
using devPoo.Class.TipoPessoa;
using devPoo.Class.TipoProduto;
using devPoo.NotificationContext;
using devPoo.SharedContext;

namespace devPoo.Eventos
{
    public class VenderProduto : Base
    {
        public DateTime DiaHoraVenda { get; set; }

        public void Vender(Produto produto, Cliente cliente, Vendedor vendedor, Pagamento pagamento)
        {
            var venda = new Venda(vendedor, cliente, produto, pagamento);
            Console.WriteLine($"Venda realizada em {DiaHoraVenda:D}");
            Console.WriteLine($"Cliente: {venda.Cliente.Nome}");
            Console.WriteLine($"Vendedor: {venda.Vendedor.Nome}");
            Console.WriteLine($"Especificações: {produto.GetPropriedadesEspecificas(produto.GetType().Name)}");
        }

        public void MostrarNotificacoes()
        {
            foreach (var notificacao in Notificacoes)
            {
                Console.WriteLine($"{notificacao.Propriedade} - {notificacao.Mensagem}");
            }
        }
    }
}
