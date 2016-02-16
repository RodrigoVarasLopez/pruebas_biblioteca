using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    [Serializable]
    public class CdDvd
    {
        public CdDvd(int id_obra, float duracion)
        {
            this.id_obra = id_obra;
            this.duracion = duracion;
        }

        public int id_obra { get; set; }
        public float duracion { get; set; }
    }
}
