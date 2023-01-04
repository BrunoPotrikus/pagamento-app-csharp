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
            if (produto == null)
            {
                AddNotificacao(new Notificacao("Produto", "Produto não selecionado"));
                MostrarNotificacoes();
            }
            else if (cliente.Nome == null)
            {
                AddNotificacao(new Notificacao("Cliente", "Cliente não identificado"));
                MostrarNotificacoes();
            }
            else if (vendedor.Nome == null)
            {
                AddNotificacao(new Notificacao("Vendedor", "Vendedor não identificado"));
                MostrarNotificacoes();
            }
            else if (pagamento == null)
            {
                AddNotificacao(new Notificacao("Pagamento", "Informar forma de pagamento"));
                MostrarNotificacoes();

            }
            else
            {
                var venda = new Venda(vendedor, cliente, produto, pagamento);
                Console.WriteLine($"Venda realizada em {DiaHoraVenda:D}");
                Console.WriteLine($"Cliente: {venda.Cliente.Nome}");
                Console.WriteLine($"Vendedor: {venda.Vendedor.Nome}");
                Console.WriteLine($"Produto: {venda.NovoProduto.Tipo} {venda.NovoProduto.Marca} {venda.NovoProduto.Nome}");
                Console.WriteLine($"Especificações:\n{produto.GetPropriedadesEspecificas(produto.GetType().Name)}");
            }
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
