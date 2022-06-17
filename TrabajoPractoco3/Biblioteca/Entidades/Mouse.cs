using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Dpi { get => dpi; set => dpi = value; }
        public float Peso { get => peso; set => peso = value; }

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
