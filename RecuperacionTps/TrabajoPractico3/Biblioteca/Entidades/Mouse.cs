using Biblioteca.Interfaces;
using System;

namespace Biblioteca.Entitdades
{
    public class Mouse : IInventario
    {
        int dpi;
        float peso;

        public Mouse(int dpi, float peso)
        {
            this.Dpi = dpi;
            this.Peso = peso;
        }

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

        public string Info()
        {
            return $"Dpi: {Dpi} Peso: {Peso}";
        }

        public string MetodoDeEntrega()
        {
            return "Lo entrega una persona con una bolsa";
        }
    }
}
