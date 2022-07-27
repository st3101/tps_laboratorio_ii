using System;
using System.Collections.Generic;

namespace Biblioteca.Entitdades
{
    public class Estante<T> where T : class
    {

        /// <summary>
        /// atributo statico y privado del id de los perifericos
        /// </summary>
        private static int id;

        /// <summary>
        /// lista generica y pricada 
        /// </summary>
        private List<T> listaInventaio;

        /// <summary>
        /// Contructor statico que asigna el id en 1 la primera vez que se ejecuta
        /// </summary>
        static Estante()
        {
            Id = 1;
        }
        /// <summary>
        /// Contructor publico que crea una lista generica en memoria
        /// </summary>
        public Estante()
        {
            this.Inventario = new List<T>();
        }

        /// <summary>
        /// Propiedad publica y statica de id 
        /// </summary>
        public static int Id { get => id; set => id = value; }

        /// <summary>
        /// Propiedad publica que asigna una lista
        /// </summary>
        public List<T> Inventario { get => listaInventaio; set => listaInventaio = value; }
        
        /// <summary>
        /// Metodo que agrega un objeto generico a una lista generica, validadndo que no se agrege algo nulo lanzando una expcion
        /// </summary>
        /// <param name="objeto">objeto a agrgar</param>
        /// <returns>true si se agrego y false si no se agrego a la lista</returns>
        /// <exception cref="ArgumentNullException">Si se intento agregar un objeto nulo</exception>
        public bool Agregar(T objeto)
        {
            if (objeto is null)
            {
                throw new ArgumentNullException(nameof(objeto));
            }

            listaInventaio.Add(objeto);
            return true;

        }

        /// <summary>
        /// metodo que busca un objeto en la lista por indice
        /// </summary>
        /// <param name="indice">Indice del objeto a buscar</param>
        /// <returns>retorna el objeto en la lista o null si no hay nada</returns>
        public T Buscar(int indice)
        {
            T aux;

            if (listaInventaio is not null)
            {
                aux = listaInventaio[indice]; 

                if (aux is not null)
                {                   
                    return aux;
                }
            }

            return null;
        }

        /// <summary>
        /// Elimina un objeto de la lista 
        /// </summary>
        /// <param name="aux">Objeto a eliminar de la lista</param>
        /// <returns>true si se elimino o false si no</returns>
        public bool Eliminar(T aux)
        {
            if(aux is not null)
            {
                listaInventaio.Remove(aux);
                return true;
            }
            return false;
        }


    }


}
