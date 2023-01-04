using System;
using devPoo.BaseClass;

namespace devPoo.Class.TipoProduto
{
    public class Notebook : Produto
    {
        public Notebook(string nome, 
                        string categoria, 
                        string tipo,
                        double preco, 
                        string marca, 
                        string processador, 
                        string memoriaRam, 
                        string armazenamento, 
                        string placaDeVideo)
            : base(nome, categoria, tipo, preco, marca)
        {
            Processador = processador;
            MemoriaRam = memoriaRam;
            Armazenamento = armazenamento;
            PlacaDeVideo = placaDeVideo;
        }

        public static string Processador { get; set; }
        public static string MemoriaRam { get; set; }
        public static string Armazenamento { get; set; }
        public static string PlacaDeVideo { get; set; }

        public static String MostraProprieadesEspecificas()
        {
            return $" Processador: {Processador}\n" +
                   $" Memória RAM: {MemoriaRam}\n" +
                   $" Armazenamento: {Armazenamento}\n" +
                   $" Placa de Vídeo: {PlacaDeVideo}";
        }
    }
}
