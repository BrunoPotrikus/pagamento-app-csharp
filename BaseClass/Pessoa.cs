using devPoo.Interfaces;
using devPoo.SharedContext;
using System;

namespace devPoo.BaseClass
{
    public abstract class Pessoa : Base, IPessoa
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
