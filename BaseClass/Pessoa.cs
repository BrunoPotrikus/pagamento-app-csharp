using devPoo.Interfaces;
using System;

namespace devPoo.BaseClass
{
    public abstract class Pessoa : IPessoa
    {
        protected Pessoa(string nome) 
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
        public Guid Id { get; set ; }
        public string Nome { get; set; }
    }
}
