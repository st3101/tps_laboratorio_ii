using Biblioteca.Entitdades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Sistema
{
    public static class conexionSql
    {
        /// <summary>
        /// atributo donde se realiza la coneccion a la base de datos
        /// </summary>
        private static string conexionString;

        /// <summary>
        /// Atributo donde se asigna el tipo de coneccion
        /// </summary>
        private static SqlCommand command;

        /// <summary>
        /// atributo donde se almasena la coneccion a la base de datos
        /// </summary>
        private static SqlConnection connection;

        static conexionSql()
        {
            conexionString = $"Data Source=.;Initial Catalog=Inventario;Integrated Security=True";

            command = new SqlCommand();
            connection = new SqlConnection(conexionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        /// <summary>
        /// Descarga de una base de datos objetos de tipo escritorios
        /// </summary>
        /// <returns>una lista de los esctritorios</returns>
        public static List<Escritorio> LeerEscritorio()
        {
            List<Escritorio> list = new List<Escritorio>();

            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM Escritorios";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        list.Add(new Escritorio(dataReader["Modelo"].ToString(), Convert.ToSingle(dataReader["MetrosCuadrados"])));
                    }
                }

                return list;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Descarga de una base de datos monitores
        /// </summary>
        /// <returns>una lista de monitores</returns>
        public static List<Monitor> LeerMonitor()
        {
            List<Monitor> list = new List<Monitor>();

            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM Monitores";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        list.Add(new Monitor(Convert.ToInt32(dataReader["Pulgadas"]), Convert.ToSingle(dataReader["Hz"])));
                    }
                }

                return list;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Descarga de una base de datos mouse
        /// </summary>
        /// <returns>Una lista de mouse</returns>
        public static List<Mouse> LeerMouse()
        {
            List<Mouse> list = new List<Mouse>();

            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM Mouses";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        list.Add(new Mouse(Convert.ToInt32(dataReader["Dpi"]), Convert.ToSingle(dataReader["Peso"])));
                    }
                }

                return list;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Sube a una base de datos una lista de escritoreios eliminando los previos
        /// </summary>
        /// <param name="listEscritorio">Lista de escritorios para subir</param>
        static public void GuardarEscritorio(List<Escritorio> listEscritorio)
        {

            try
            {
                connection.Open();
                command.CommandText = "DELETE Escritorios";
                command.ExecuteNonQuery();

                foreach (Escritorio item in listEscritorio)
                {
                  
                    command.CommandText = $"INSERT INTO Escritorios VALUES (@Modelo,@MetrosCuadrados)";

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Modelo", item.Modelo);
                    command.Parameters.AddWithValue("@MetrosCuadrados", item.MetrosCuadrado);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
                 
        }   
        /// <summary>
        /// Sube a una base de datos una lista de monitores borrando los previos
        /// </summary>
        /// <param name="list">Lista de monitores a guardar</param>
        static public void GuardarMonitor(List<Monitor> list)
        {

            try
            {
                connection.Open();

                command.CommandText = "DELETE Monitores";
                command.ExecuteNonQuery();
                foreach (Monitor item in list)
                {              
                    command.CommandText = $"INSERT INTO Monitores VALUES (@Pulgadas,@Hz)";

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Pulgadas", item.Pulgadas);
                    command.Parameters.AddWithValue("@Hz", item.Hz);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
                 
        }      
        /// <summary>
        /// Sube a una lista mouse a una base de datos
        /// </summary>
        /// <param name="list">Lista mouse a subir </param>
        static public void GuardarMouse(List<Mouse> list)
        {

            try
            {
                connection.Open();
                command.CommandText = "DELETE Mouses";
                command.ExecuteNonQuery();

                foreach (Mouse item in list)
                {
                    command.CommandText = $"INSERT INTO Escritorios VALUES (@Dpi,@Peso)";

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Dpi", item.Dpi);
                    command.Parameters.AddWithValue("@Peso", item.Peso);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
                 
        }    
    } 
}
