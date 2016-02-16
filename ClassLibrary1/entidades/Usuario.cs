using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    [Serializable]
    public class Usuario
    {
        public Usuario(int codigo, string usuario, string contraseña, string nombre, string apellido, string dni, string telefono)
        {
            this.codigo = codigo;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
        }

        public Usuario(string usuario, string contraseña, string nombre, string apellido, string dni, string telefono)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
        }

        public int codigo { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }
    }
}
