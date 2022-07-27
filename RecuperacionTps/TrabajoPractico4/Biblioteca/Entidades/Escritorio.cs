using Biblioteca.Interfaces;
using System;


namespace Biblioteca.Entitdades
{
    public class Escritorio : IInventario
    {
        /// <summary>
        /// Atributo privado  
        /// </summary>
        private string modelo;

        /// <summary>
        /// Atributo privado  
        /// </summary>
        private float metrosCuadrado;

        /// <summary>
        /// Contructor de la clase escritorio que asigna valores 
        /// </summary>
        /// <param name="modelo">Modelo de escritorio  que se asigna</param>
        /// <param name="metrosCuadrado">valor de metros cuadrados que se asigna</param>
        public Escritorio(string modelo, float metrosCuadrado)
        {
            this.Modelo = modelo;
            this.MetrosCuadrado = metrosCuadrado;
        }

        /// <summary>
        /// Propiedad que asigna valor a modelo y lanza una exepcion si es nulo
        /// </summary>
        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Modelo no puede ser nulo");
                }
                modelo = value;
            }
        }
        /// <summary>
        /// Propiedad que asigna metros cuadrados que valida que metros no seas negativo 
        /// </summary>
        public float MetrosCuadrado
        {
            get
            {
                return metrosCuadrado;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Escritorio));
                }
                metrosCuadrado = value;
            }
        }


        /// <summary>
        /// Retorna modelo y metros cuadrados 
        /// </summary>
        /// <returns></returns>
        public string Info()
        {
            return $"Modelo: {Modelo} Metros Cuadrados: {MetrosCuadrado}";
        }

        /// <summary>
        /// Informa la entrega
        /// </summary>
        /// <returns>string de metodo de entrga</returns>
        public string MetodoDeEntrega()
        {
            return "Es llevado por dos personas";
        }

    }
}
