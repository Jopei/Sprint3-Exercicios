using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Xunit.Abstractions;
using SistemaAgendamento.Core.Commands;
using SistemaAgendamento.Core.Models;
using SistemaAgendamento.Infrastructure;
using SistemaAgendamento.Services.Handlers;
namespace SistemaAgendamento.Test
{
    public class Cadastra
    {
        [Fact]
        public void CadastroDB()
        {
            var agd = new CadastrarAgendamento("Titulo", new Sala(), new DateTime(), new DateTime());
            var opcoes = new DbContextOptionsBuilder<Infrastructure.DbContext>()
                .UseInMemoryDatabase("DbContext")//Usando a memoria
                .Options;
            var motivo = new Infrastructure.DbContext(opcoes);
            var repo = new RepositorioAgendamento(motivo);
            var handler = new CadastraAgendamentoHandler(rp);
            handler.Execute(agd);//Enviando o Agendamento criado
            var oap = repo.ObtemAgendamentos(fim => fim.Titulo == "Titulo").FirstOrDefault();

        }
    }
        public class FinalizaeAtualiza//Teste de agendamento 
        {
            [Fact] 
            public void Atualizar()
            {
                Sala sala = new Sala();
                var ListaAgendamento = new List<AgendamentoModel>
                {
                new AgendamentoModel(1,"Titulo", sala, new DateTime(2021,12,13), new DateTime(2022,11,14), StatusAgendamento.Criada),
                };
                var mock = new Mock<IRepositorioAgendamento>();
                mock.Setup(verifica => verifica.ObtemAgendamentos(It.IsAny<Func<AgendamentoModel, bool>>()))
                    .Returns(ListaAgendamento);
                var repo = mock.Object;

                var handler = new GerenciaFimAgendamentoHandler(repo);

                mock.Verify(verifica => verifica.AtualizarAgendamentos(It.IsAny<AgendamentoModel[]>()), Times.Once());
            }
        }
        /*private class FactAttribute : AtItribute
        {
        }*/
 }
