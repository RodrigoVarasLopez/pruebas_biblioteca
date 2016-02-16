using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    [Serializable]
    public class Contener
    {
        public Contener(int id_obra, int id_catalogo)
        {
            this.id_obra = id_obra;
            this.id_catalogo = id_catalogo;
        }

        public int id_obra { get; set; }
        public int id_catalogo { get; set; }

    }
}
