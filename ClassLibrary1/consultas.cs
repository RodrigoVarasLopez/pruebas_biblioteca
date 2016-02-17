using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class consultas
    {
        //Insercciones
        static public string adduser(entidades.Usuario usuario)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            if (conn != null)
            {
                conn.Open();
                string SQL = "INSERT INTO [prueba].[dbo].[Usuarios] ([usuario],[contraseña],[nombre],[apellido],[dni],[telefono]) VALUES ('" + usuario.usuario + "','" + usuario.contraseña + "','" + usuario.nombre + "','" + usuario.apellido + "','" + usuario.dni + "','" + usuario.telefono + "')";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int nrows = cmd.ExecuteNonQuery();
                conn.Close();

                return nrows.ToString();
            }
            return "no";
        }

        static public string addObra(entidades.Obra obra)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            if (conn != null)
            {
                conn.Open();
                string SQL = "INSERT INTO [prueba].[dbo].[Obra] ([nombre],[fecha_publi],[categoria]) VALUES ('" + obra.nombre + "','" + obra.fecha_publicacion + "','" + obra.categoria + "')";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int nrows = cmd.ExecuteNonQuery();
                conn.Close();
                return nrows.ToString();
            }
            return "no";
        }

        static public string addAurtor(entidades.Autores autor)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            if (conn != null)
            {
                conn.Open();
                string SQL = "INSERT INTO [prueba].[dbo].[Autores] ([nombre],[apellidos],[año]) VALUES ('" + autor.nombre + "','" + autor.apellidos + "','" + autor.año + "')";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int nrows = cmd.ExecuteNonQuery();
                conn.Close();
                return nrows.ToString();
            }
            return "no";
        }

        static public string addCrear(entidades.Obra obra, entidades.Autores autor)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            if (conn != null)
            {
                conn.Open();
                string SQL = "INSERT INTO [prueba].[dbo].[Crear] ([id_obra],[id_autor]) VALUES ('" + obra.id_obra + "','" + autor.id_autor + "')";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int nrows = cmd.ExecuteNonQuery();
                conn.Close();
                return nrows.ToString();
            }
            return "no";
        }

        static public string addLibro(entidades.Libro libro, entidades.Obra obra)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            if (conn != null)
            {
                conn.Open();
                string SQL = "INSERT INTO [prueba].[dbo].[Libro] ([id_obra],[isbn]) VALUES ('" + obra.id_obra + "','" + libro.isbn + "')";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int nrows = cmd.ExecuteNonQuery();
                conn.Close();
                return nrows.ToString();
            }
            return "no";
        }

        static public string addCd(entidades.CdDvd cd, entidades.Obra obra)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            if (conn != null)
            {
                conn.Open();
                string SQL = "INSERT INTO [prueba].[dbo].[Cd/Dvd] ([id_obra],[duracion]) VALUES ('" + obra.id_obra + "','" + cd.duracion + "')";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int nrows = cmd.ExecuteNonQuery();
                conn.Close();
                return nrows.ToString();
            }
            return "no";
        }

        static public string addCatalogo(entidades.Catalogo catalogo)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            if (conn != null)
            {
                conn.Open();
                string SQL = "INSERT INTO [prueba].[dbo].[Catalogo] ([nombre],[version]) VALUES ('" + catalogo.nombre + "','" + catalogo.version + "')";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int nrows = cmd.ExecuteNonQuery();
                conn.Close();
                return nrows.ToString();
            }
            return "no";

        }

        static public string addContener(entidades.Obra obra, entidades.Catalogo catalogo)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            if (conn != null)
            {
                conn.Open();
                string SQL = "INSERT INTO [prueba].[dbo].[Contener] ([id_obra],[id_catalogo]) VALUES ('" + catalogo.id_catalogo + "','" + obra.id_obra + "')";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int nrows = cmd.ExecuteNonQuery();
                conn.Close();
                return nrows.ToString();
            }
            return "no";

        }

        static public string addCopia(entidades.Copias copias, int id_obra)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            if (conn != null)
            {
                conn.Open();
                string SQL = "INSERT INTO [prueba].[dbo].[Copias] ([id_obra],[comentarios],[estado]) VALUES ('" + id_obra + "','" + copias.comentarios + "','" + copias.estado + "')";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int nrows = cmd.ExecuteNonQuery();
                conn.Close();
                return nrows.ToString();
            }
            return "no";
        }

        //Todo esto va en la logica pero esta asegurado que funciona

        static public string addLibroCompleto(entidades.Libro libro, entidades.Obra obra, entidades.Autores autor, entidades.Catalogo catalogo)
        {
            addObra(obra);
            entidades.Obra idObra = isObra(obra.nombre, obra.fecha_publicacion);
            addLibro(libro, idObra);
            //Condición si existe autor

            addAurtor(autor);
            entidades.Autores idAutor = isAutor(autor.nombre, autor.apellidos);
            addCrear(idObra, idAutor);
            entidades.Catalogo idCatalogo = isCatalogo("Propio");
            addContener(idObra, idCatalogo);
            //Falta añadir una copia
            return "OK";
        }


        //Consultas

        public static entidades.Obra isObra(string nombre, DateTime fecha)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            conn.Open();
            string SQL = "SELECT [id_obra],[nombre],[fecha_publi],[categoria] FROM [prueba].[dbo].[Obra] WHERE [nombre]='" + nombre + "'and [fecha_publi]='" + fecha + "'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                entidades.Obra obra1 = new entidades.Obra(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3));
                conn.Close();
                return obra1;
            }
            else
            {
                return null;
            }
        }

        public static entidades.Autores isAutor(string nombre, string apellidos)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            conn.Open();
            string SQL = "SELECT [id_autor],[nombre],[apellidos],[año] FROM [prueba].[dbo].[Autores] WHERE [nombre]='" + nombre + "'and [apellidos]='" + apellidos + "'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                entidades.Autores autor1 = new entidades.Autores(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3));
                conn.Close();
                return autor1;
            }
            else
            {
                return null;
            }
        }

        public static entidades.Autores isAutor(string nombre )
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            conn.Open();
            string SQL = "SELECT [id_autor],[nombre],[apellidos],[año] FROM [prueba].[dbo].[Autores] WHERE [nombre]='" + nombre + "'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                entidades.Autores autor1 = new entidades.Autores(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3));
                conn.Close();
                return autor1;
            }
            else
            {
                return null;
            }
        }


        public static entidades.Catalogo isCatalogo(string nombre)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            conn.Open();
            string SQL = "SELECT [id_catalogo],[nombre],[version] FROM [prueba].[dbo].[Catalogo] WHERE [nombre]='" + nombre + "'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                entidades.Catalogo catalogo1 = new entidades.Catalogo(reader.GetInt32(0), reader.GetString(1), (float)(double)reader["version"]);
                conn.Close();
                return catalogo1;
            }
            else
            {
                return null;
            }
        }
        public static entidades.Copias isCopia(int id_obra, int estado)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            conn.Open();
            string SQL = "SELECT [n_copia],[id_obra],[comentarios],[estado] FROM [prueba].[dbo].[Copias] WHERE [id_obra]='" + id_obra + "'and [estado]='" + estado + "'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                entidades.Copias copia1 = new entidades.Copias(reader.GetInt32(0), reader.GetInt32(1), (string)reader["comentarios"], (int)reader["estado"]);
                conn.Close();
                return copia1;
            }
            else
            {
                return null;
            }
        }
        public static entidades.Catalogo isCopia(string nombre, int estado)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            conn.Open();
            string SQL = "SELECT [n_copia],[id_obra],[comentarios],[estado] FROM [prueba].[dbo].[Catalogo] WHERE [nombre]='" + nombre + "'and [estado]='" + estado + "'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                entidades.Catalogo catalogo1 = new entidades.Catalogo(reader.GetInt32(0), reader.GetString(1), (float)(double)reader["version"]);
                conn.Close();
                return catalogo1;
            }
            else
            {
                return null;
            }
        }

        public static entidades.Usuario isUsuario(string usuario, string contraseña)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            conn.Open();
            string SQL = "SELECT [cod_socio],[usuario],[contraseña],[nombre],[apellido],[dni],[telefono] FROM [prueba].[dbo].[Usuarios] WHERE [usuario]='" + usuario + "'and [contraseña]='" + contraseña + "'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                entidades.Usuario usuario1 = new entidades.Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                conn.Close();
                return usuario1;
            }
            else
            {
                return null;
            }
        }

        //public static SqlDataReader isObraMovil(string nombre)
        //{

        //    SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
        //    conn.Open();
        //    string SQL = "SELECT [cod_socio],[usuario],[contraseña],[nombre],[apellido],[dni],[telefono] FROM [prueba].[dbo].[Usuarios] WHERE [usuario]='" + usuario + "'and [contraseña]='" + contraseña + "'";
        //    SqlCommand cmd = new SqlCommand(SQL, conn);
        //    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.SingleResult);

        //    if (reader.HasRows)
        //    {
        //        return reader;
        //    }

        //    else
        //    {
        //        return null;
        //    }
        //}


        public static Modelo.entidades.Obra isObraMovil(string nombre)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");
            conn.Open();
            string SQL = "SELECT [id_obra],[nombre],[fecha_publi],[categoria] FROM [prueba].[dbo].[Obra] WHERE [nombre]='" + nombre + "'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList al = new ArrayList();
            if (reader.HasRows)
            {
                //while (reader.Read())
                //{
                reader.Read();
                entidades.Obra obra1 = new entidades.Obra(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3));
                //al.Add(obra1);
                conn.Close();
                return obra1;
            }

            //return al;
            //}

            else
            {
                return null;
            }
        }

        //    public entidades.Usuario isUsuario(string usuario, string contraseña)
        //    {


        //        SqlConnection conn = new SqlConnection(@"Data Source=ROV-PC\sqlexpress;Initial Catalog=prueba;Persist Security Info=True;User ID=Oscar;Password=123456");


        //        if (conn != null)
        //        {
        //            conn.Open();
        //            string SQL = "SELECT [usuario],[contraseña],[nombre],[apellido],[dni],[telefono] FROM [prueba].[dbo].[Usuarios] WHERE [usuario]='" + usuario + "'and [contraseña]='" + contraseña + "'";
        //            SqlCommand cmd = new SqlCommand(SQL, conn);
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            if (reader.HasRows)
        //            {
        //                reader.Read();

        //                entidades.Usuario usuario1 = new entidades.Usuario();
        //                usuario1.usuario = reader["usuario"].ToString();
        //                usuario1.contraseña = reader["contraseña"].ToString();
        //                usuario1.nombre = reader["nombre"].ToString();
        //                usuario1.apellido = reader["apellido"].ToString();
        //                usuario1.dni = reader["dni"].ToString();
        //                usuario1.telefono = reader["telefono"].ToString();
        //                conn.Close();


        //                return usuario1;
        //            }
        //            conn.Close();

        //        }
        //        return null;
        //    }
    }
}
