using devPoo.Interfaces;
using System;

namespace devPoo.BaseClass
{
    public abstract class Produto : IProduto
    {
        protected Produto(string nome, string categoria, double preco, string marca) 
        {
            Id = Guid.NewGuid();
            Nome= nome;
            Categoria= categoria;
            Preco= preco;
            Marca= marca;
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public string Marca { get; set; }
    }
}
