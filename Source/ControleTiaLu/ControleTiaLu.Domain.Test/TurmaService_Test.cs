using System;
using System.Linq;
using ControleTiaLu.Domain.Entities;
using ControleTiaLu.Domain.Services;
using ControleTiaLu.Domain.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControleTiaLu.Domain.Test
{
    [TestClass]
    public class TurmaService_Test
    {
        [TestMethod]
        public void Validar_Criacao_Turma_Sucesso()
        {
            TurmaService turmaService = new TurmaService();

            Turma turma1 = new Turma("1a Turma A",new DateTime(1, 1, 1, 15, 0, 0),new DateTime(1, 1, 1, 17, 0, 0));

            turma1.AlterarDescricao("Nova Turma B");

            turmaService.CriarTurma(turma1);

            Assert.IsTrue(turma1.Codigo > 0);
        }

        [TestMethod]
        public void Validar_Criacao_Turma_Horario_Falha()
        {
            TurmaService turmaService = new TurmaService();

            try
            {
                Turma turma1 = new Turma("1a", new DateTime(1, 1, 1, 17, 0, 0), new DateTime(1, 1, 1, 15, 0, 0));

            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Informações de turma inválida"));
            }
            
        }

        [TestMethod]
        public void Validar_Criacao_Turma_E_Associar_Aluno_Sucesso()
        {
            TurmaService turmaService = new TurmaService();

            Turma turma1 = new Turma("1a Turma A", new DateTime(1, 1, 1, 15, 0, 0), new DateTime(1, 1, 1, 17, 0, 0));

            Aluno aluno = new Aluno();
            aluno.Nome = "ReInaLdo";

            turma1.AdicionarAluno(aluno);

            Assert.IsTrue(turma1.Alunos.Any(al => al.Nome.ToUpper() == "REINALDO"));
        }
    }
}
