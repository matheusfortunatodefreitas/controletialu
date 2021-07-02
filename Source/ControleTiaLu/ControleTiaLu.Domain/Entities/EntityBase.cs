using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTiaLu.Domain.Entities
{
    public class EntityBase
    {
        public int Codigo { get; private set; }

        public void AtribuirCodigo(int codigo)
        {
            Codigo = codigo;
        }
    }
}
