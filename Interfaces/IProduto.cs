using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devPoo.Interfaces
{
    internal interface IProduto
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Categoria { get; set; }
        double Preco { get; set; }
        string Marca { get; set; }
    }
}
