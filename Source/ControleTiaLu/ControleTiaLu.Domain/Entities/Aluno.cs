using ControleTiaLu.Domain.Interfaces;

namespace ControleTiaLu.Domain.Entities
{
    public class Aluno : EntityBase
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string  Telefone { get; set; }
        public string NomeResponsavel { get; set; }

        public bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
