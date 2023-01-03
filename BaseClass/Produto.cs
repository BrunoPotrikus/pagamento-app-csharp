using devPoo.Class.TipoProduto;
using devPoo.Interfaces;
using System;

namespace devPoo.BaseClass
{
    public abstract class Produto : IProduto
    {
        protected Produto(string nome, string categoria, string tipo, double preco, string marca) 
        {
            Id = Guid.NewGuid();
            Nome= nome;
            Categoria= categoria;
            Tipo = tipo;
            Preco= preco;
            Marca= marca;
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public double Preco { get; set; }
        public string Marca { get; set; }

        public String GetPropriedadesEspecificas(string tipo)
        {
            switch (tipo)
            {
                case "Notebook":
                    return Notebook.MostraProprieadesEspecificas();
                default:
                    return "Tipo nã existe";
            }
        }
    }
}
