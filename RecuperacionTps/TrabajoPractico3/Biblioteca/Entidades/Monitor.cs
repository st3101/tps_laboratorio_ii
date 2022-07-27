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
        int pulgadas;
        float hz;

        public Monitor(int pulgadas, float hz)
        {
            Pulgadas = pulgadas;
            Hz = hz;
        }

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

        public string Info()
        {
            return $"Pulgadas: {Pulgadas} Hz: {Hz}";
        }

        public string MetodoDeEntrega()
        {
            return $"Por un persona";
        }
    }
}
