using Biblioteca.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca.Entitdades
{
    public class Escritorio : IInventario
    {
        string modelo;
        float metrosCuadrado;

        public Escritorio(string modelo, float metrosCuadrado)
        {
            this.Modelo = modelo;
            this.MetrosCuadrado = metrosCuadrado;
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("Modelo no puede ser nulo");
                }
                modelo = value;
            }
        }
        public float MetrosCuadrado
        { get
            {
                return metrosCuadrado;
            }
            set
            {
                if(value > 1)
                {
                     3
                }
            }
            }

        public string Info()
        {

        }

        public string MetodoDeEntrega()
        {
            throw new NotImplementedException();
        }
    }
}
