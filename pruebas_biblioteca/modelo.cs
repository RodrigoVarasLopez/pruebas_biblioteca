using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca;
using System.Configuration;

namespace pruebas_biblioteca
{
    class modelo
    {
        static void Main(string[] args)

        {
            //string añadido = Class1.adduser(1,"hoola","hola","hola","hola",777);
            //Console.WriteLine(añadido);
            //string añadido =Class1.adduser("osc", "123", "oscar", "Varas", "719444951P", "+34774447882");
            //Console.WriteLine(añadido);
            //Console.ReadKey();
            //Class1 c1 = new Class1();
            //entidades.Usuario u = c1.isUsuario("osc", "123");
            //Console.WriteLine(u.nombre+" "+u.apellido);
            //Console.ReadKey();
            DateTime fecha = new DateTime(2008, 3, 15);

            entidades.Obra obra = new entidades.Obra("el caballero", fecha, "caballeresca");
            string añadida = consultas.addcopia(obra);
            Console.WriteLine(añadida);
            Console.ReadKey();
            mod
        }   
        
    
    }
}
