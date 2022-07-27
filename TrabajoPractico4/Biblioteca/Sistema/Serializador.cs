using Biblioteca.Entitdades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca.Sistema
{
    public static class Serializador<T>
    {
        /// <summary>
        /// Guarda lista de escritorios con el nombre escritorio
        /// </summary>
        static public void GuardarEscritorio()
        {
            Guardar<List<Escritorio>>("Escriorio", Sistema.EstanteEscritorio.Inventario);
        }

        /// <summary>
        /// Guarda lista de Monitores con el nombre Monitor
        /// </summary>
        static public void GuardarMonoitor()
        {
            Guardar<List<Monitor>>("Monitor", Sistema.EstanteMonitor.Inventario);
        }

        /// <summary>
        /// Guarda lista de Mouse con el nombre Mouse
        /// </summary>
        static public void GuardarMouse()
        {
            Guardar<List<Mouse>>("Mouse", Sistema.EstanteMouse.Inventario);
        }

        /// <summary>
        /// llama al metodo leer de escritorios
        /// </summary>
        /// <returns>Retorna una lista generica escritorios</returns>
        static public T LeerEscritorio()
        {
            return Leer("Escriorio");
        }

        /// <summary>
        /// Llama a la metodo leer de monitores
        /// </summary>
        /// <returns>Retorna una lista generica de monitores</returns>
        static public T LeerMonitores()
        {
            return Leer("Monitor");
        }

        /// <summary>
        /// Llama al metodo leer mouse.
        /// </summary>
        /// <returns>Retorna una lista generica de mouse</returns>
        static public T LeerMouse()
        {
            return Leer("Mouse");
        }

        /// <summary>
        /// Guarda en un archivo una lista generica con el nombre especificado 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nombreArchivo">Nombre del archivo con que se va a guardar</param>
        /// <param name="datos">generico de dato a guardar</param>
        /// <exception cref="Exception">Si la ruta esta mal o no se puedo guardar</exception>
        static public void Guardar<T>(string nombreArchivo, T datos)
        {
            string ruta = System.AppDomain.CurrentDomain.BaseDirectory + $"/{nombreArchivo}.JSON";

            try
            {
                File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(datos));
            }
            catch (Exception)
            {

                throw new Exception($"Error en el archivo {nombreArchivo}");
            }
        }

        /// <summary>
        /// Lee de un archivo y lo deserializa
        /// </summary>
        /// <param name="nombreArchivo">Nombre del archivo</param>
        /// <returns>retorna objeto generico deserilizada</returns>
        /// <exception cref="Exception">expcion si no encuentra el archivo</exception>
        public static T Leer(string nombreArchivo)
        {
            string ruta = System.AppDomain.CurrentDomain.BaseDirectory + $"/{nombreArchivo}";
            try
            {
                return JsonSerializer.Deserialize<T>(File.ReadAllText(ruta));
            }
            catch (Exception x)
            {

                throw new Exception(x.Message);
            }

        }

    }
}
