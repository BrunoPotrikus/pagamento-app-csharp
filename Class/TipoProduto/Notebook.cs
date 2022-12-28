using System;
using devPoo.BaseClass;

namespace devPoo.Class.TipoProduto
{
    public class Notebook : Produto
    {
        public string Processador { get; set; }
        public string MemoriaRam { get; set; }
        public string Armazenamento { get; set; }
        public string PlacaDeVideo { get; set; }
    }
}
