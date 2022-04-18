using System;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char retorno = operador;
            if(operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                retorno = '+';
            }
            return retorno;
        }

        public static double Operar(Operando num1, Operando num2,char operador)
        {
            double resultado = double.MinValue;

            switch (ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                break;
                case '-':
                     resultado = num1 - num2;
                break;
                case '/':
                     resultado = num1 / num2;
                break;
                case '*':
                     resultado = num1 * num2;
                break;
            }
            return resultado;
        }
    }
}
