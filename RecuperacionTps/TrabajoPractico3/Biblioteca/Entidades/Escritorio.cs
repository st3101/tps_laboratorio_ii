using Biblioteca.Interfaces;
using System;


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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Modelo no puede ser nulo");
                }
                modelo = value;
            }
        }
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



        public string Info()
        {
            return $"Modelo: {Modelo} Metros Cuadrados: {MetrosCuadrado}";
        }

        public string MetodoDeEntrega()
        {
            return "Es llevado por dos personas";
        }
    }
}
