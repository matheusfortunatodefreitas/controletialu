using ControleTiaLu.Domain.Entities;

namespace ControleTiaLu.Domain.Extensions
{
    public static class TurmaExtesnsion
    {
        public static void AlterarDescricaoNova(this Turma turma) 
        {
            turma.AlterarDescricao(turma.Descricao + " - Valor NOVO");
        }
    }
}
