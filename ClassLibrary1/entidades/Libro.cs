using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    [Serializable]
    public class Libro
    {
        public Libro(string isbn)
        {
            this.isbn = isbn;
        }

        public Libro(int id_obra, string isbn)
        {
            this.id_obra = id_obra;
            this.isbn = isbn;
        }

        public int id_obra { get; set; }
        public string isbn { get; set; }
    }
}
