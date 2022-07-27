using Biblioteca.Interfaces;
using System;

namespace Biblioteca.Entitdades
{
    public class Mouse : IInventario
    {
        /// <summary>
        /// Atributo parivado
        /// </summary>
        private int dpi;

        /// <summary>
        /// Atributo privado
        /// </summary>
        private float peso;

        /// <summary>
        /// Contructor publico que asigna valores por propiedades
        /// </summary>
        /// <param name="dpi"></param>
        /// <param name="peso"></param>
        public Mouse(int dpi, float peso)
        {
            this.Dpi = dpi;
            this.Peso = peso;
        }

        /// <summary>
        /// Propiedad que asigna que dpi se mayor a 0 o lanza una expcion
        /// </summary>
        public int Dpi
        {
            get => dpi;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(dpi));
                }

                dpi = value;
            }
        }

        /// <summary>
        /// Propiedad que asigna peso y valida que sea mayor a 0 o lanza una expcion
        /// </summary>
        public float Peso
        {
            get => peso;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(peso));
                }
                peso = value;
            }
        }

        /// <summary>
        /// Informacion de mouse
        /// </summary>
        /// <returns>string de atrivutos de mouse</returns>
        public string Info()
        {
            return $"Dpi: {Dpi} Peso: {Peso}";
        }

        /// <summary>
        /// metodo de entrga
        /// </summary>
        /// <returns>string con el metodo correco de envio</returns>
        public string MetodoDeEntrega()
        {
            return "Lo entrega una persona con una bolsa";
        }
    }
}
