namespace devPoo.NotificationContext
{
    public abstract class Notificavel
    {
        public List<Notificacao> Notificacoes { get; set; }

        public Notificavel()
        {
            Notificacoes = new List<Notificacao>();
        }

        public void AddNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }

        public void AddListaNotificacoes(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }

        public bool Invalido => Notificacoes.Any();
    }
}
