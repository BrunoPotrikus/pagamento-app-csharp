using devPoo.BaseClass;

namespace devPoo.Class.ConsultarCadastraProdutos
{
    public class Cadastrar<P>
    {
        public Cadastrar()
        {
            ListaProdutos = new List<Produto>();
        }
        public IList<Produto> ListaProdutos { get; set; }

        public void CadastrarProduto(Produto produto)
        {
            ListaProdutos.Add(produto);
            Console.WriteLine($"Produtos cadastrados: {ListaProdutos.Count}");
        }
    }
}
