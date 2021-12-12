using SistemaAgendamento.Core.Models;
using SistemaAgendamento.Core.Commands;
using SistemaAgendamento.Infrastructure;
using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace SistemaAgendamento.Services.Handlers
{
    public class CadastraAgendamentoHandler
    {
        IRepositorioAgendamento _repo;

        public CadastraAgendamentoHandler()
        {
            _repo = new RepositorioAgendamento();
        }

        public void Execute(CadastrarAgendamento comando)
        {
            var agendamento = new AgendamentoModel
            (
                id: 0,
                titulo: comando.Titulo,
                sala: comando.Sala,
                inicio: comando.Inicio,
                fim: comando.Fim,
                status: StatusAgendamento.Criada

            );
            _repo.IncluirAgendamento(agendamento);
        }
    }
}
