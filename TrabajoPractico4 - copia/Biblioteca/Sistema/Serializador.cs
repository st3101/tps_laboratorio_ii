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
        static public void GuardarEscritorio()
        {
            Guardar<List<Escritorio>>("Escriorio", Sistema.EstanteEscritorio.Inventario);
        }

        static public void GuardarMonoitor()
        {
            Guardar<List<Monitor>>("Monitor", Sistema.EstanteMonitor.Inventario);
        }

        static public void GuardarMouse()
        {
            Guardar<List<Mouse>>("Mouse", Sistema.EstanteMouse.Inventario);
        }

        static public T LeerEscritorio()
        {
            return Leer("Escriorio");
        }

        static public T LeerMonitores()
        {
            return Leer("Monitor");
        }

        static public T LeerMouse()
        {
            return Leer("Mouse");
        }
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
