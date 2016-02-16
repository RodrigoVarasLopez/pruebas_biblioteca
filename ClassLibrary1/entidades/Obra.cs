using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    [Serializable]
    public class Obra
    {
        public Obra() { }
        public Obra(string nombre, DateTime fecha_publicacion, string categoria)
        {
            this.nombre = nombre;
            this.fecha_publicacion = fecha_publicacion;
            this.categoria = categoria;
        }

        public Obra(int id_obra, string nombre, DateTime fecha_publicacion, string categoria)
        {
            this.id_obra = id_obra;
            this.nombre = nombre;
            this.fecha_publicacion = fecha_publicacion;
            this.categoria = categoria;
        }

        public int id_obra { get; set; }
        public string nombre { get; set; }
        public DateTime fecha_publicacion { get; set; }
        public string categoria { get; set; }  
    }
}
