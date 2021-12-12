using SistemaAgendamento.Core.Models;
using System;

namespace SistemaAgendamento.Core.Commands
{
    public class CadastrarAgendamento
    {
        public CadastrarAgendamento(string descrição, Sala sala, DateTime inicio, DateTime fim)
        {
            Titulo = Titulo;//descrição;
            Sala = sala;
            Inicio = inicio;
            Fim = fim; ;
        }

        public string Titulo { get; set; }

        public Sala Sala { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }
    }
}
