using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entitdades
{
    public class Monitor : IInventario
    {
        /// <summary>
        /// Atributo privado
        /// </summary>
        private int pulgadas;

        /// <summary>
        /// Atrobuto pricado
        /// </summary>
        private  float hz;

        /// <summary>
        /// Contructor publico donde asignar pulgadas y hz
        /// </summary>
        /// <param name="pulgadas"></param>
        /// <param name="hz"></param>
        public Monitor(int pulgadas, float hz)
        {
            Pulgadas = pulgadas;
            Hz = hz;
        }

        /// <summary>
        /// Propiedad que asigna pulgadas y valida que sea mayor a 0 o lanza una expcion
        /// </summary>
        public int Pulgadas
        {
            get => pulgadas;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(pulgadas));
                }
                pulgadas = value;
            }
        }
        /// <summary>
        /// Propiedad que asigna hz y valida que sea mayor a 0 o lanza una exepcion
        /// </summary>
        public float Hz
        {
            get => hz;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Hz));
                }
                hz = value;
            }
        }

        /// <summary>
        /// Informa sobre monitor
        /// </summary>
        /// <returns>string pulgads y hz</returns>
        public string Info()
        {
            return $"Pulgadas: {Pulgadas} Hz: {Hz}";
        }

        /// <summary>
        /// Informa entrega
        /// </summary>
        /// <returns>string de metodo de entrega</returns>
        public string MetodoDeEntrega()
        {
            return $"Por un persona";
        }
    }
}
