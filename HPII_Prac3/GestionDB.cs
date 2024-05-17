using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace HPII_Prac3
{
    class GestionDB
    {
        string strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString.ToString();
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        string mensaje = "";
        public GestionDB()
        {
           
        }
      
        /// <summary>
        /// Establecemos conexion con la base de datos
        /// </summary>
        public void Conectar()
        {
            try
            {
                connection = new SqlConnection(strCon);
                connection.Open();
            }
            catch (SqlException ex)
            {
                mensaje = "No es posible conectar al servidor por: " + ex.Message;
            }
        }
        public override string ToString()
        {
            return mensaje;
        }

        /// <summary>
        /// Metodo que nos puede hacer una consulta que se encuentre en entero, en este caso nos fue util para las cedulas de estudiantes y docentes
        /// </summary>
        /// <param name="query"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public List<int> listarCC(string query,int pos )
        {
            List<int> CC = new List<int>();
            Conectar();
            try
            {
                command = new SqlCommand(query,connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {                   
                    CC.Add(reader.GetInt32(pos));
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Se presento un error: " + ex.Message;
            }
            reader.Close();
            connection.Close();

            return CC;
        }

        /// <summary>
        /// Metodo que nos puede hacer una consulta que se encuentre en string, en este caso nos fue util para los nombres de estudiantes y docentes
        /// </summary>
        /// <param name="query"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public List<string> listarNom(string query, int pos)
        {
            List<string> Nombre = new List<string>();
            Conectar();
            try
            {
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Nombre.Add(reader.GetString(pos));
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Se presento un error: " + ex.Message;
            }
            connection.Close();

            return Nombre;
        }


        /// <summary>
        /// Metodo que nos guarda las asesorias en la basse de datos
        /// </summary>
        /// <param name="asesoria"></param>
        /// <returns></returns>
        public int GuardarAsesoria(Asesoria asesoria)//Recibimos un objeto tipo asesoria
        {
            int respuesta = -1;
            Conectar();
            try
            {
                string query = "insert into Asesoria (fecha, hora, CC, CCD)" +
                    "values(@fecha,@hora,@CC,@CCD)";//Creamos la query con variables dentro del sql server
                command = new SqlCommand(query, connection);
                //Y empezamos a dar valor a esas variables
                command.Parameters.AddWithValue("@fecha", Convert.ToDateTime(asesoria.Fecha));
                command.Parameters.AddWithValue("@hora", asesoria.Hora);
                command.Parameters.AddWithValue("@CC", asesoria.CC1);
                command.Parameters.AddWithValue("@CCD", asesoria.CCD1);
                respuesta = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                mensaje = "Se presento un error : " + ex.Message;
            }
            connection.Close();
            return respuesta;
        }

        /// <summary>
        /// Metodo que nos deja buscar las asesorias que se encuentren programadas para una fecha
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public List<Asesoria> BuscarAsesoriaXFecha(string fecha)   //Recibimos la fecha         
        {
            List<Asesoria> listAsesoria = new List<Asesoria>();
            Conectar();
            try
            {
                //Creamos la query con inner join
                string query = $"select Estudiante.nombre, Docente.nombreD, Asesoria.Hora FROM Docente INNER JOIN Asesoria ON Docente.CCD = Asesoria.CCD INNER JOIN Estudiante ON Asesoria.CC = Estudiante.CC where fecha in('{fecha}')";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Solo guardamos los datos que necesitamos
                    Asesoria asesoria = new Asesoria();
                    asesoria.NombreE1 = reader.GetString(0);
                    asesoria.NombreD1 = reader.GetString(1);
                    asesoria.Hora = reader.GetInt32(2);
                    listAsesoria.Add(asesoria);
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Se presento un error: " + ex.Message;
            }

            connection.Close();

            return listAsesoria;//Retornamos la lista que contiene todos los objetos(Asesorias) que se encuentran para la fecha que se recibio por parametro
        }


        /// <summary>
        /// Metodo que nos deja buscar las asesorias que se encuentren programadas para una docente en especifico
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public List<Asesoria> BuscarAsesoriaXDocente(string nombre)//Recibimos el nombre del docente
        {
            List<Asesoria> listAsesoria = new List<Asesoria>();
            Conectar();
            try
            {
                //Query con inner join
                string query = $"select Estudiante.nombre, Docente.nombreD, Asesoria.Hora FROM Docente INNER JOIN Asesoria ON Docente.CCD = Asesoria.CCD INNER JOIN Estudiante ON Asesoria.CC = Estudiante.CC where nombreD in('{nombre}')";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Asesoria asesoria = new Asesoria();
                    asesoria.NombreE1 = reader.GetString(0);
                    asesoria.NombreD1 = reader.GetString(1);
                    asesoria.Hora = reader.GetInt32(2);
                    listAsesoria.Add(asesoria);
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Se presento un error: " + ex.Message;
            }

            connection.Close();

            return listAsesoria;//Retornamos la lista que contiene todos los objetos(Asesorias) que se encuentran programdos para un docente
        }

    }
}
