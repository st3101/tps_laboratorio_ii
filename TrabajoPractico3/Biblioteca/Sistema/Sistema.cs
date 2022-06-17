using Biblioteca.Entitdades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Biblioteca.Sistema
{
    static public class Sistema
    {


        static Estante<Escritorio> estanteEscritorio;
        static Estante<Monitor> estanteMonitor;
        static Estante<Mouse> estanteMouse;


        static Sistema()
        {
            EstanteEscritorio = new Estante<Escritorio>();
            EstanteMonitor = new Estante<Monitor>();
            EstanteMouse = new Estante<Mouse>();

        }

        public static Estante<Escritorio> EstanteEscritorio { get => estanteEscritorio; set => estanteEscritorio = value; }
        public static Estante<Monitor> EstanteMonitor { get => estanteMonitor; set => estanteMonitor = value; }
        public static Estante<Mouse> EstanteMouse { get => estanteMouse; set => estanteMouse = value; }

        static public void AgregarEscritorio(string modelo, string metrosCuadrados)
        {
            Escritorio auxEscritorio = new Escritorio(modelo, float.Parse(metrosCuadrados));

            if (auxEscritorio is null)
            {
                throw new ArgumentNullException(nameof(auxEscritorio));
            }

            EstanteEscritorio.Agregar(auxEscritorio);

        }

        static public void AgregarMonitor(string pulgada, string hz)
        {
            Monitor axuMonitor = new Monitor(int.Parse(pulgada), float.Parse(hz));
            {
                if (axuMonitor is null)
                {
                    throw new ArgumentNullException(nameof(axuMonitor));
                }

                EstanteMonitor.Agregar(axuMonitor);
            }
        }

        static public void AgregarMouse(string dpi, string peso)
        {
            Mouse auxMouse = new Mouse(int.Parse(dpi), float.Parse(peso));

            if (auxMouse is null)
            {
                throw new ArgumentNullException(nameof(auxMouse));
            }

            EstanteMouse.Agregar(auxMouse);
        }

        static public Escritorio BuscarEscritorio(int indice)
        {
            Escritorio auxEscritorio;

            auxEscritorio = estanteEscritorio.Buscar(indice);

            if (auxEscritorio is null)
            {
                throw new ArgumentNullException(nameof(auxEscritorio));
            }

            return auxEscritorio;
        }
        static public Monitor BuscarMonitor(int i)
        {
            Monitor auxMonitor;

            auxMonitor = EstanteMonitor.Buscar(i);

            if (auxMonitor is null)
            {
                throw new ArgumentNullException(nameof(auxMonitor));
            }

            return auxMonitor;
        }
        static public Mouse BuscarMouse(int i)
        {
            Mouse auxMouse;

            auxMouse = EstanteMouse.Buscar(i);

            if (auxMouse is null)
            {
                throw new ArgumentNullException(nameof(auxMouse));
            }

            return auxMouse;
        }
        static public bool PisarInfoEscritorio(string modelo, string metrosCuadrados, Escritorio auxEscritorio)
        {

            if (auxEscritorio is not null)
            {
                auxEscritorio.Modelo = modelo;
                auxEscritorio.MetrosCuadrado = float.Parse(metrosCuadrados);
                return true;
            }

            return false;
        }

        static public bool PisarInfoMonitor(string pugadas, string hz, Monitor auxMonitor)
        {
            if (auxMonitor is not null)
            {
                auxMonitor.Pulgadas = int.Parse(pugadas);
                auxMonitor.Hz = float.Parse(hz);
                return true;
            }

            return false;
        }

        static public bool PisarInfoMouse(string dpi, string peso, Mouse auxMouse)
        {
            if (auxMouse is not null)
            {
                auxMouse.Dpi = int.Parse(dpi);
                auxMouse.Peso = float.Parse(peso);
                return true;
            }

            return false;
        }

        static public bool BorrarEscritorio(int i)
        {
            Escritorio auxEscritorio;
            if (i >= 0)
            {
                auxEscritorio = Sistema.BuscarEscritorio(i);

                if (auxEscritorio is not null && EstanteEscritorio is not null)
                {

                    EstanteEscritorio.Eliminar(auxEscritorio);
                    return true;
                }
            }

            return false;
        }

        static public bool BorrarMonitor(int i)
        {
            Monitor auxMonitor;
            if (i >= 0)
            {
                auxMonitor = Sistema.BuscarMonitor(i);

                if (auxMonitor is not null && EstanteMonitor is not null)
                {
                    EstanteMonitor.Eliminar(auxMonitor);
                    return true;
                }


            }
            return false;
        }
        static public bool BorrarMouse(int i)
        {
            Mouse auxMouse;

            if (i >= 0)
            {
                auxMouse = Sistema.BuscarMouse(i);

                if (auxMouse is not null && EstanteMouse is not null)
                {
                    EstanteMouse.Eliminar(auxMouse);
                    return true;
                }
            }
            return false;
        }

        static public string MetodoDeEntregaEscritorio(int i)
        {
            Escritorio auxEscritorio;


            auxEscritorio = BuscarEscritorio(i);

            if (auxEscritorio is not null && EstanteEscritorio is not null)
            {
                return auxEscritorio.MetodoDeEntrega();
            }


            return null;
        }

        static public string MetodoDeEntrgaMonitor(int i)
        {
            Monitor auxMonitor;

            auxMonitor = BuscarMonitor(i);

            if (auxMonitor is not null && EstanteMonitor is not null)
            {
                return auxMonitor.MetodoDeEntrega();
            }

            return null;
        }

        static public string MetodoDeEntrgaMouse(int i)
        {
            Mouse auxMouse;

            auxMouse = BuscarMouse(i);

            if (auxMouse is not null && EstanteMouse is not null)
            {
                return auxMouse.MetodoDeEntrega();
            }

            return null;
        }
        static public void LeerArchicos()
        {
            EstanteEscritorio.Inventario = Serializador<List<Escritorio>>.Leer("Escritorio");
        }
    }
}






