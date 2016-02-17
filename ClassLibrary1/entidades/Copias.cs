using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    [Serializable]
    public class Copias
    {
        public Copias(int n_copia, int id_obra, string comentarios, int estado)
        {
            this.n_copia = n_copia;
            this.id_obra = id_obra;
            this.comentarios = comentarios;
            this.estado = estado;
        }

        public Copias(int id_obra, string comentarios, int estado)
        {
            this.id_obra = id_obra;
            this.comentarios = comentarios;
            this.estado = estado;
        }

        public Copias(string comentarios, int estado)
        {
            this.comentarios = comentarios;
            this.estado = estado;
        }

        public Copias()
        {
        }

        public int n_copia { get; set; }
        public int id_obra { get; set; }
        public string comentarios { get; set; }
        public int estado { get; set; }
    }
}
