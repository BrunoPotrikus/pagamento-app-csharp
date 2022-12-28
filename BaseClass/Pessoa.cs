using devPoo.Interfaces;
using System;

namespace devPoo.BaseClass
{
    public abstract class Pessoa : IPessoa
    {
        public int Id { get; set ; }
        public string Nome { get; set; }
    }
}
