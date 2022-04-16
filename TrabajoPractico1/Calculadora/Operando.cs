using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Operando
    {

        /// <summary>
        /// Atributo privado al cual operar.
        /// </summary>
        private double numero;

        /// <summary>
        /// Propidad que asigna un numero.
        /// </summary>
        public double Numero
        {
            set
            {
                numero = value;
            }
        }
 
        /// <summary>
        /// Constructor por defecto que asigna 0 a numero.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que valida que sea un numero valido y lo asigna.
        /// </summary>
        /// <param name="numero">Valor al que se le asigna al numero</param>
        public Operando(string numero)
        {
            this.numero = ValidarOperando(numero);
        }

        /// <summary>
        /// Valida que sea un numero valido y si no lo asigna en 0
        /// </summary>
        /// <param name="StrNumero">sting de numeor a validar</param>
        /// <returns>Retorna el numero validado del tipo double</returns>
        private double ValidarOperando(string StrNumero)
        {
            double auxDouble = 0;

            if (double.TryParse(StrNumero, out auxDouble))
            {
                return auxDouble;
            }

            return 0;
        }
        /// <summary>
        /// Valida si es un numero binario
        /// </summary>
        /// <param name="binario">Binario de tipo sting a validar</param>
        /// <returns>true si es binario y false si no es binario</returns>
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

        /// <summary>
        /// Conbierte un binario a decimal
        /// </summary>
        /// <param name="binario">binario de tipo sting a convertir</param>
        /// <returns>decimal del tipo string</returns>
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
        /// <summary>
        /// Tranforma decimal a binarario
        /// </summary>
        /// <param name="numero">numero binario del tipo sting</param>
        /// <returns>Un sting de un numero binario</returns>
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
        /// <summary>
        /// Tranforma un decimal a binario
        /// </summary>
        /// <param name="numero">numero binario del tipo double</param>
        /// <returns>Un binario del tipo string</returns>
        public static string DecimalBinario(double numero)
        {
            string retorno = "Valor Invalido";
            if (numero >= 0)
            {
                retorno = Convert.ToString(Convert.ToInt32(numero), 2);
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga del operador "+" que suma dos numeros de la clase operando
        /// </summary>
        /// <param name="n1">Primer parametro del tipo operaador</param>
        /// <param name="n2">Segundo parametro del tipo operaador</param>
        /// <returns>resultado del tipo double</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Sobrecargar del operador "-" que resta el segundo numero al primero de la clase operador
        /// </summary>
        /// <param name="n1">Primer parametro del tipo operador</param>
        /// <param name="n2">Segundo parametro del tipo operador</param>
        /// <returns>resultado de la resta en double</returns>
        public static double operator -(Operando n1, Operando n2)
        { 
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Sobrecargar del operar "*" multiplica los numero de la clase operador 
        /// </summary>
        /// <param name="n1">Primer parametro del tipo operador</param>
        /// <param name="n2">Segundo parametro del tipo operador</param>
        /// <returns>Resultado de la multiplicacion del tipo double</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Sobrecarga de operador "/" que divide el segundo numero al primero y si el divisor es 0 asigna el minValue de la clase double 
        /// </summary>
        /// <param name="n1">Primer parametro de la clase operador</param>
        /// <param name="n2">Segundo parametro de la clase operador </param>
        /// <returns>El resultado de la divicion del tipo double</returns>
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
