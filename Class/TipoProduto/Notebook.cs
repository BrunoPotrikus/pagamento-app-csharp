﻿using System;
using devPoo.BaseClass;

namespace devPoo.Class.TipoProduto
{
    public class Notebook : Produto
    {
        public Notebook(string nome, 
                        string categoria, 
                        double preco, 
                        string marca, 
                        string processador, 
                        string memoriaRam, 
                        string armazenamento, 
                        string placaDeVideo)
            : base(nome, categoria, preco, marca)
        {
            Processador = processador;
            MemoriaRam = memoriaRam;
            Armazenamento = armazenamento;
            PlacaDeVideo = placaDeVideo;
        }

        public string Processador { get; set; }
        public string MemoriaRam { get; set; }
        public string Armazenamento { get; set; }
        public string PlacaDeVideo { get; set; }
    }
}
