using System;

namespace Biblioteca
{
    public static class Calculadora
    {
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
