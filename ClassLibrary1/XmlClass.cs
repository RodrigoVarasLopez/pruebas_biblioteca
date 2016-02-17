using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLibrary1
{
    public class XmlClass
    {
        public static void xmlconver(string ruta)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(ruta);

            XmlNode cata = doc.SelectSingleNode("/Cataloglo");
            string catalogo = cata.Attributes["biblioteca"].ToString();

            XmlNode ver = doc.SelectSingleNode("/Cataloglo/Info");
            float version = float.Parse(ver["Version"].ToString());
            Modelo.consultas.addCatalogo(new Modelo.entidades.Catalogo(catalogo, version));
            Modelo.entidades.Catalogo idCatalogo = Modelo.consultas.isCatalogo(catalogo);

            XmlNodeList list = doc.SelectNodes("/Catalogo/Obras/Obra");
            foreach (XmlNode node in list)
            {
                string nombre = node["Titulo"].ToString();
                DateTime fecha_publicacion = Convert.ToDateTime(node["Fecha"].ToString());
                string categoria = node.Attributes["categoria"].ToString();
                Modelo.consultas.addObra(new Modelo.entidades.Obra(nombre, fecha_publicacion, categoria));
                Modelo.entidades.Obra idObra = Modelo.consultas.isObra(nombre, fecha_publicacion);

                Modelo.consultas.addContener(idObra, idCatalogo);

                int nCopias = Convert.ToInt32(node.Attributes["copias"].ToString());
                for (int i = 0; i < nCopias; i++)
                {
                    Modelo.consultas.addCopia(new Modelo.entidades.Copias(), idObra.id_obra);
                }

                string tipo = node.Attributes["tipo"].ToString();
                if (tipo == "libro")
                {
                    string isbn = node["Isbn"].ToString();
                    Modelo.consultas.addLibro(new Modelo.entidades.Libro(isbn), idObra);
                }
                else
                {
                    string duracion = node["Duracion"].ToString();
                    Modelo.consultas.addCd(new Modelo.entidades.CdDvd(duracion), idObra);
                }

                XmlNodeList autores = node.SelectNodes("/Autores");
                foreach (XmlNode autor in autores)
                {
                    string nombreAutor = node["Autor"].ToString();
                    Modelo.consultas.addAurtor(new Modelo.entidades.Autores(nombreAutor));
                    Modelo.entidades.Autores idAutor = Modelo.consultas.isAutor(nombreAutor);
                    Modelo.consultas.addCrear(idObra, idAutor);
                }


            }
        }
    }
}
