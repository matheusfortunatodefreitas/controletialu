using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTiaLu.Domain.Entities
{
    public class Turma
    {
        public Turma()
        {

        }

        public Turma(string descricao, DateTime horaInicial, DateTime horaFinal)
        {
            Descricao = descricao;
            HoraInicial = horaInicial;
            HoraFinal = horaFinal;
        }

        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

        public void AdicionarAluno(Aluno aluno) 
        {
            if (Alunos.Any(al => al.Nome.Equals(aluno.Nome) && al.NomeResponsavel.Equals(aluno.NomeResponsavel) && al.Telefone.Equals(aluno.Telefone)))
            {
                throw new Exception("Aluno já cadastrado!");
            }

            Alunos.Add(aluno);
        }

        public void RemoverAluno(int codigoAluno) 
        {
            Alunos.RemoveAll(aluno => aluno.Codigo == codigoAluno);
        }
    }
}
