using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    [Serializable]
    public class Crear
    {
        public Crear(int id_obra, int id_autor)
        {
            this.id_obra = id_obra;
            this.id_autor = id_autor;
        }

        public int id_obra { get; set; }
        public int id_autor { get; set; }
    }
}
