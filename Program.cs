using System;
using System.Collections.Concurrent;
using System.Runtime;

public class Program
{
    public static void Main(string[] args)
    {
        var pagamentoBoleto = new PagamentoBoleto();
        pagamentoBoleto.Pagar();
        pagamentoBoleto.VerVencimento(DateTime.Now);
        pagamentoBoleto.CodigoDeBarras = "123456";

        Console.Clear();
        Console.WriteLine(pagamentoBoleto.VerVencimento(DateTime.Now));
        Console.WriteLine(pagamentoBoleto.CodigoDeBarras);
    }

    public class Pagamento
    {
        protected DateTime Vencimento;

        public virtual void Pagar()
        {
           
        }
    }

    internal class PagamentoBoleto : Pagamento
    {
        public int ValorBoleto { get; set; }

        private string _codigoDeBarras;

        public string CodigoDeBarras
        {
            get { return _codigoDeBarras; }
            set { _codigoDeBarras = value; }
        }

        public override void Pagar()
        {
            base.Pagar();
        }

        public DateTime VerVencimento(DateTime vencimento)
        {
            base.Vencimento = vencimento;
            return base.Vencimento;
        }
    }
}
