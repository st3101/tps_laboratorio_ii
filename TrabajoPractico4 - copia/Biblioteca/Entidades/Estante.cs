using System;
using System.Collections.Generic;

namespace Biblioteca.Entitdades
{
    public class Estante<T> where T : class
    {


        static int id;
        List<T> listaInventaio;

        static Estante()
        {
            Id = 1;
        }
        public Estante()
        {
            this.Inventario = new List<T>();
        }

        public static int Id { get => id; set => id = value; }
        public List<T> Inventario { get => listaInventaio; set => listaInventaio = value; }
        
        public bool Agregar(T objeto)
        {
            if (objeto is null)
            {
                throw new ArgumentNullException(nameof(objeto));
            }

            listaInventaio.Add(objeto);
            return true;

        }

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
