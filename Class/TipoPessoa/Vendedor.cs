using System;
using devPoo.BaseClass;
using devPoo.NotificationContext;

namespace devPoo.Class.TipoPessoa
{
    public class Vendedor: Pessoa
    {
        public Vendedor(string nome)
            : base(nome)
        {
            if (nome == null)
            {
                AddNotificacao(new Notificacao("Vendedor", "Vendedor não identificado"));
                foreach(var notificacao in MostraNotificacao())
                {
                    Console.WriteLine(notificacao);
                }
            }
        }
    }
}
