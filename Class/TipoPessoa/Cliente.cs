using devPoo.BaseClass;
using devPoo.NotificationContext;

namespace devPoo.Class.TipoPessoa
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome) 
            : base(nome)
        { 
            if (nome == null)
            {
                AddNotificacao(new Notificacao("Cliente", "Cliente não identificado"));
            }
        }
    }
}
