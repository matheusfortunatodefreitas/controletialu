using ControleTiaLu.Domain.Entities;
using System.Collections.Generic;

namespace ControleTiaLu.Domain.Services
{
    public class TurmaService
    {


        public void CriarTurma(Turma turma) 
        {
            turma.Codigo = 1;
        }

        public void AssociarAlunosTurma(Turma turma, List<Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                turma.AdicionarAluno(aluno);
            }
        }

        public void AssociarAlunoTurma(Turma turma, Aluno aluno)
        {
            turma.AdicionarAluno(aluno);
        }

    }
}
