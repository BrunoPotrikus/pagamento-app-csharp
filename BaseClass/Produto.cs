using devPoo.Interfaces;
using System;

namespace devPoo.BaseClass
{
    public abstract class Produto : IProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public string Marca { get; set; }
    }
}
