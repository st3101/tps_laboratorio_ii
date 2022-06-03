using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Intefaces;

namespace Biblioteca.Entitdades
{
    public class Estante<T> :IAdministracion
    {
        static int id;
        List<T> listaInventaio;

        static  Estante()
        {
            Id = 1;
        }
        public Estante()
        {
            this.Inventario = new List<T>();
        }

        public static int Id { get => id; set => id = value; }
        public List<T> Inventario { get => listaInventaio; set => listaInventaio = value; }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public bool Entrega()
        {
            throw new NotImplementedException();
        }
    }


}
