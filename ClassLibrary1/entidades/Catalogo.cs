using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    [Serializable]
    public class Catalogo
    {
        public Catalogo(int id_catalogo, string nombre)
        {
            this.id_catalogo = id_catalogo;
            this.nombre = nombre;
        }

        public Catalogo(string nombre, float version)
        {
            this.nombre = nombre;
            this.version = version;
        }

        public Catalogo(int id_catalogo, string nombre, float version)
        {
            this.id_catalogo = id_catalogo;
            this.nombre = nombre;
            this.version = version;
        }

        public int id_catalogo { get; set; }
        public string nombre { get; set; }
        public float version { get; set; }
    }
}
