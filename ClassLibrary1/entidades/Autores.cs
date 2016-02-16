using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    [Serializable]
    public class Autores
    {
        public Autores(string nombre, string apellidos, DateTime año)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.año = año;
        }

        public Autores(int id_autor, string nombre, string apellidos, DateTime año)
        {
            this.id_autor = id_autor;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.año = año;
        }

        public int id_autor { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public DateTime año { get; set; }
    }
}
