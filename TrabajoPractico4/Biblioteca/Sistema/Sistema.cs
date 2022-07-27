using Biblioteca.Entitdades;
using System;
using System.Collections.Generic;


namespace Biblioteca.Sistema
{
    static public class Sistema
    {
        /// <summary>
        /// Delegado para crear un evento
        /// </summary>
        public delegate void dele();

        /// <summary>
        /// Evento de la clase sistema
        /// </summary>
        public static event dele evento;

        static Estante<Escritorio> estanteEscritorio;
        static Estante<Monitor> estanteMonitor;
        static Estante<Mouse> estanteMouse;


        /// <summary>
        /// Contructor statico que crea estantes 
        /// </summary>
        static Sistema()
        {
            EstanteEscritorio = new Estante<Escritorio>();
            EstanteMonitor = new Estante<Monitor>();
            EstanteMouse = new Estante<Mouse>();
        }

        /// <summary>
        /// Propiedades de la clase Estante de escritorio
        /// </summary>
        public static Estante<Escritorio> EstanteEscritorio { get => estanteEscritorio; set => estanteEscritorio = value; }

        /// <summary>
        /// Propiedad de la clase estante monitor 
        /// </summary>
        public static Estante<Monitor> EstanteMonitor { get => estanteMonitor; set => estanteMonitor = value; }

        /// <summary>
        /// Propiedad de la clase mouse
        /// </summary>
        public static Estante<Mouse> EstanteMouse { get => estanteMouse; set => estanteMouse = value; }

        /// <summary>
        /// Agreaga un escritorio al estante
        /// </summary>
        /// <param name="modelo">Modelo </param>
        /// <param name="metrosCuadrados">Metros cuadrados</param>
        /// <returns>true si lo agrego</returns>
        /// <exception cref="ArgumentNullException">si no pude crear un escritorio</exception>
        static public bool AgregarEscritorio(string modelo, string metrosCuadrados)
        {
            Escritorio auxEscritorio = new Escritorio(modelo, float.Parse(metrosCuadrados));

            if (auxEscritorio is null)
            {
                throw new ArgumentNullException(nameof(auxEscritorio));
            }

            EstanteEscritorio.Agregar(auxEscritorio);
            return true;

        }

        /// <summary>
        /// Agrega un monior a un estante
        /// </summary>
        /// <param name="pulgada">pulgadas</param>
        /// <param name="hz">hz</param>
        /// <exception cref="ArgumentNullException">Si no pudo crear el escritorio</exception>
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

        /// <summary>
        /// Agrega un mouse a un estante
        /// </summary>
        /// <param name="dpi">dpi</param>
        /// <param name="peso">peso</param>
        /// <exception cref="ArgumentNullException">Si no se puede crear se lanza</exception>
        static public void AgregarMouse(string dpi, string peso)
        {
            Mouse auxMouse = new Mouse(int.Parse(dpi), float.Parse(peso));

            if (auxMouse is null)
            {
                throw new ArgumentNullException(nameof(auxMouse));
            }

            EstanteMouse.Agregar(auxMouse);
        }

        /// <summary>
        /// Busca un escritorio en el estante 
        /// </summary>
        /// <param name="indice">indice del escritorio a buscar</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">si no se encontro el escritorio</exception>
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

        /// <summary>
        ///Buscar un monitor en estante  
        /// </summary>
        /// <param name="i">Indice donde buscar el monitor</param>
        /// <returns>Retorna el moinitor</returns>
        /// <exception cref="ArgumentNullException">Si no encuentra el monitor</exception>
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
        /// <summary>
        /// Buscar el mouse en el estante
        /// </summary>
        /// <param name="i">Indice donde buscar</param>
        /// <returns>El mouse </returns>
        /// <exception cref="ArgumentNullException">Si no lo' encuentra</exception>
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
        /// <summary>
        /// Cambia los atributos de un escritorio
        /// </summary>
        /// <param name="modelo">Nuevo modelo</param>
        /// <param name="metrosCuadrados">Nuevo metro cuadrado</param>
        /// <param name="auxEscritorio">Direccion de memoria a cual cambiar</param>
        /// <returns>true si se cambio o false si no escritorio es null</returns>
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

        /// <summary>
        /// Cambia los atributos de un monitor 
        /// </summary>
        /// <param name="pugadas">Nueva pulgadas</param>
        /// <param name="hz">Nuevos Hz</param>
        /// <param name="auxMonitor">Direccion de memoria cual cambiar</param>
        /// <returns>true si se cambio o false si no escritorio es null</returns>
        static public bool PisarInfoMonitor(string pugadas, string hz, Monitor auxMonitor)
        {
            int auxPulgadas = int.Parse(pugadas);
            float auxHz = float.Parse(hz);


            if (auxMonitor is not null)
            {
                auxMonitor.Pulgadas = auxPulgadas;
                auxMonitor.Hz = auxHz;
                return true;
            }



            return false;
        }

        /// <summary>
        /// Cambia los atributos de un mouse
        /// </summary>
        /// <param name="dpi">Nuevo dpi+</param>
        /// <param name="peso">Nuevo Peso</param>
        /// <param name="auxMouse">Direccion de memoria de mouse</param>
        /// <returns>true si se cambio o false si no escritorio es null</returns>
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

        /// <summary>
        /// Borra un escritorio
        /// </summary>
        /// <param name="i">Indice del escritorio a borrar</param>
        /// <returns>True si lo borro</returns>
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
        /// <summary>
        /// Borra un monitor
        /// </summary>
        /// <param name="i">Indice del monitor a borrar</param>
        /// <returns>true si lo borro o false si no lo borro</returns>
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

        /// <summary>
        /// Borra un mouse
        /// </summary>
        /// <param name="i">Indice del mouse a borrar</param>
        /// <returns>True si lo borro o false si no lo borro</returns>
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

        /// <summary>
        /// llama al metodo de entrega de un escritorio
        /// </summary>
        /// <param name="i">Indice del escritorio</param>
        /// <returns>String de metodo de entrega o null si no lo encontro</returns>
        static public string MetodoDeEntregaEscritorio(int i)
        {
            Escritorio auxEscritorio = null;


            auxEscritorio = BuscarEscritorio(i);

            if (auxEscritorio is not null && EstanteEscritorio is not null)
            {

                return auxEscritorio.MetodoDeEntrega();
            }


            return null;
        }

        /// <summary>
        /// Usa el metdo de entrega de un monitor
        /// </summary>
        /// <param name="i">indice de monitor</param>
        /// <returns>String de metodo de entrega o null si no lo encontro</returns>
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

        /// <summary>
        /// Llama al metodo de entrega de mouse 
        /// </summary>
        /// <param name="i">Indice del mouse</param>
        /// <returns>String de metodo de entrga o null si no existe</returns>
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

        /// <summary>
        /// Guarda en estante escritorio los archivos de escritorio deseriualizados
        /// </summary>
        static public void LeerArchicos()
        {
            EstanteEscritorio.Inventario = Serializador<List<Escritorio>>.Leer("Escritorio");
        }

        /// <summary>
        /// Lee de una base de datos lista de objetos y simula una operacion demandate
        /// </summary>
        static public void LeerDatosSql()
        {
            Sistema.EstanteEscritorio.Inventario = conexionSql.LeerEscritorio();
            Sistema.EstanteMonitor.Inventario = conexionSql.LeerMonitor();
            Sistema.EstanteMouse.Inventario = conexionSql.LeerMouse();

            System.Threading.Thread.Sleep(2000);
        }

        /// <summary>
        /// invoca el evento si no es nulo
        /// </summary>
        public static void InvocarEvento()
        {
            if (evento != null)
            {
                evento.Invoke();
            }
        }

    }
}
