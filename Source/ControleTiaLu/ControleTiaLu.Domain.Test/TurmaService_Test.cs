using System;
using ControleTiaLu.Domain.Entities;
using ControleTiaLu.Domain.Services;
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

            Turma turma1 = new Turma();
            turma1.Descricao = "1a tarde";
            turma1.HoraInicial = new DateTime(1, 1, 1, 15, 0, 0);
            turma1.HoraFinal = new DateTime(1, 1, 1, 17, 0, 0);

            turmaService.CriarTurma(turma1);

            Assert.IsTrue(turma1.Codigo > 0);
        }

        [TestMethod]
        public void Validar_Criacao_Turma_Horario_Ok_Sucesso()
        {
            TurmaService turmaService = new TurmaService();

            Turma turma1 = new Turma();
            turma1.Descricao = "1a tarde";
            turma1.HoraInicial = new DateTime(1, 1, 1, 17, 0, 0);
            turma1.HoraFinal = new DateTime(1, 1, 1, 15, 0, 0);

            turmaService.CriarTurma(turma1);

            Assert.IsTrue(turma1.Codigo > 0);
        }
    }
}
