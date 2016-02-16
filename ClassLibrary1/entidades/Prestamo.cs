using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    [Serializable]
    public class Prestamo
    {
        public Prestamo(int id, int cod_socio, int n_copia, string tipo_prestamo, DateTime fecha_prestamo, DateTime fecha_devolucion, DateTime fecha_tope)
        {
            this.id = id;
            this.cod_socio = cod_socio;
            this.n_copia = n_copia;
            this.tipo_prestamo = tipo_prestamo;
            this.fecha_prestamo = fecha_prestamo;
            this.fecha_devolucion = fecha_devolucion;
            this.fecha_tope = fecha_tope;
        }

        public int id { get; set; }
        public int cod_socio { get; set; }
        public int n_copia { get; set; }
        public string tipo_prestamo { get; set; }
        public DateTime fecha_prestamo { get; set; }
        public DateTime fecha_devolucion { get; set; }
        public DateTime fecha_tope { get; set; }
    }
}
