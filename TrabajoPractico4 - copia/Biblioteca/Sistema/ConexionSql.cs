using Biblioteca.Entitdades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Sistema
{
    public static class conexionSql
    {
        static string conexionString;
        static SqlCommand command;
        static SqlConnection connection;

        static conexionSql()
        {
            conexionString = $"Data Source=.;Initial Catalog=Inventario;Integrated Security=True";

            command = new SqlCommand();
            connection = new SqlConnection(conexionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

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
