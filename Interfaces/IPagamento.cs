using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devPoo.Interfaces
{
    internal interface IPagamento
    {
        DateTime Vencimento { get; set; }
        double Valor { get; set; }
        void Pagar(DateTime dataPagamento);
    }
}
