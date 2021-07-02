using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleTiaLu.Domain.Entities
{
    public class Turma : EntityBase
    {
        private List<Aluno> _alunos = new List<Aluno>();

        public Turma(string descricao, DateTime horaInicial, DateTime horaFinal)
        {
            Descricao = descricao;
            HoraInicial = horaInicial;
            HoraFinal = horaFinal;

            if (!Validate())
            {
                throw new Exception("Informações de turma inválida");
            }

        }

        public string Descricao { get; private set; }
        public DateTime HoraInicial { get; private set; }
        public DateTime HoraFinal { get; private set; }
        public IEnumerable<Aluno> Alunos { get { return _alunos; } } 

        public void AlterarDescricao(string descricao) 
        {
            if (!ValidarDescricao(descricao))
            {
                throw new Exception("Descrição inválida!");
            }

            Descricao = descricao;
        }

        public void AdicionarAluno(Aluno aluno) 
        {
            if (_alunos.Any(al => al.Nome.Equals(aluno.Nome) && al.NomeResponsavel.Equals(aluno.NomeResponsavel) && al.Telefone.Equals(aluno.Telefone)))
            {
                throw new Exception("Aluno já cadastrado!");
            }

            _alunos.Add(aluno);
        }

        public void RemoverAluno(int codigoAluno) 
        {
            _alunos.RemoveAll(aluno => aluno.Codigo == codigoAluno);
        }

        public bool Validate() 
        {
            var validarDesc = ValidarDescricao(Descricao);
            var validarHoraInicial = HoraInicial != DateTime.MinValue;
            var validarHoraFinal = HoraFinal != DateTime.MinValue;
            var validarHoras = HoraInicial < HoraFinal;

            return validarDesc && validarHoraInicial && validarHoraFinal && validarHoras;
        }

        private bool ValidarDescricao(string descricao) 
        {
            return !string.IsNullOrEmpty(descricao.Trim()) && descricao.Trim().Length >= 5;
        }
    }
}
