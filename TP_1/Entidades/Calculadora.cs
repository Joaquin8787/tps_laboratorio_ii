using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador pasado por parametro
        /// </summary>
        /// <param name="operador"></param>
        /// <returns> retorna el operador si pudo y el operador "+" si no lo logro </returns>
        private static char ValidarOperador(char operador)
        {
            char retorno = operador;
            if (operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                retorno = '+';
            }
            return retorno;
        }
        /// <summary>
        /// Valida y realiza la operacion de los numeros y el operador pasados por parametro
        /// </summary>
        /// <param name="num1">Objeto del tipo Operando</param>
        /// <param name="num2">Objeto del tipo Operando</param>
        /// <param name="operador">Operador del tipo char</param>
        /// <returns>Retorna el resultado de tipo double si pudo y el valor minimo del double si no lo logro</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
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