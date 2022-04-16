using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Operando
    {
        private double numero;

        public double Numero
        {
            set
            {
                numero = value;
            }
        }
 
        public Operando()
        {
            this.numero = 0;
        }

        public Operando(string numero)
        {
            this.numero = ValidarOperando(numero);
        }

        private double ValidarOperando(string StrNumero)
        {
            double auxDouble = 0;

            if (double.TryParse(StrNumero, out auxDouble))
            {
                return auxDouble;
            }

            return 0;
        }
        public static bool EsBinario(string binario)
        {
            bool retorno = false;

            for (int i = 0; i < binario.Length; i++)
            {
                retorno = false;

                if (binario[i] == '0' || binario[i] == '1')
                {
                    retorno = true;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return retorno;
        }

        public static string BinarioDecimal(string binario)
        {
            string retorno = "Valor Invalido";

            if (Operando.EsBinario(binario))
            {
                int i;
                int j;
                int buffer = 0;
                char valorActural;

                j = binario.Length - 1;

                for (i = 0; i < binario.Length; i++)
                {
                    valorActural = binario[j];
                    j--;
                    if (valorActural == '0')
                    {
                        continue;
                    }
                    else if (valorActural == '1')
                    {
                        buffer += (int)Math.Pow(2, i);
                    }
                    else
                    {
                        break;
                    }
                }
                if (i == binario.Length)
                {
                    retorno = buffer.ToString();
                }
            }
            return retorno;
        }
        public static string DecimalBinario(string numero)
        {
            string retorno = "Valor Invalido";
            double valorNumero;
            if (Double.TryParse(numero, out valorNumero))
            {
                retorno = DecimalBinario(valorNumero);
            }
            return retorno;
        }
        public static string DecimalBinario(double numero)
        {
            string retorno = "Valor Invalido";
            if (numero >= 0)
            {
                retorno = Convert.ToString(Convert.ToInt32(numero), 2);
            }
            return retorno;
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)
        { 
            return n1.numero - n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }

            return n1.numero / n2.numero;
        }

    }
}
