using System;
using System.Collections.Generic;
using TCC.Business.Notificacoes;

namespace TCC.Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
