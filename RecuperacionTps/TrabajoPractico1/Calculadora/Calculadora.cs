using System;

namespace Biblioteca
{
    public static class Calculadora
    {
        /// <summary>
        /// Opera los valores del tipo operador dependiendo del operacion elegida
        /// </summary>
        /// <param name="num1">Primero parametro del tipo operador</param>
        /// <param name="num2">Segundo parametro del tipo operador</param>
        /// <param name="operador"></param>
        /// <returns>El resultado de la operacion elegia del tipo de dato double</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char opcion = ValidarOperador(operador);
            double retorno = 0;

            switch (opcion)
            {
                case '+':
                    retorno = num1 + num2;
                    break;

                case '-':
                    retorno = num1 - num2;
                    break;

                case '/':
                    retorno = num1 / num2;
                    break;

                case '*':
                    retorno = num1 * num2;
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que el operador sea valido en caso contrario asigna "+"
        /// </summary>
        /// <param name="operador">Operador del tipo char a validar</param>
        /// <returns>Retorno del operador validado</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }

            return '+';
        }
    }
}
