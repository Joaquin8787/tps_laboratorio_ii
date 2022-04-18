using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        /// <summary>
        /// Atributo de la clase Operando
        /// </summary>
        private double numero;

        //PROPIEDAD
        /// <summary>
        /// Valida y asigna valor al atributo numero
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        //OPERADORES
        /// <summary>
        /// Realiza la operacion suma con los 2 objetos pasados por parametro
        /// </summary>
        /// <param name="n1">Objeto del tipo Operando</param>
        /// <param name="n2">Objeto del tipo Operando</param>
        /// <returns> Retorna el resultado (double) de la operacion </returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Realiza la operacion resta con los 2 objetos pasados por parametro
        /// </summary>
        /// <param name="n1">Objeto del tipo Operando</param>
        /// <param name="n2">Objeto del tipo Operando</param>
        /// <returns> Retorna el resultado (double) de la operacion </returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Realiza la operacion multiplicacion con los 2 objetos pasados por parametro
        /// </summary>
        /// <param name="n1">Objeto del tipo Operando</param>
        /// <param name="n2">Objeto del tipo Operando</param>
        /// <returns> Retorna el resultado (double) de la operacion </returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Valida que el 2do Operando sea distinto de 0 y realiza la operacion division con los 2 objetos pasados por parametro
        /// </summary>
        /// <param name="n1">Objeto del tipo Operando</param>
        /// <param name="n2">Objeto del tipo Operando</param>
        /// <returns> Retorna el resultado (double) de la operacion si pudo y el minimo valor (double) si no lo logro </returns>
        public static double operator /(Operando n1, Operando n2)
        {
            //Valido que no se divida por 0
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            return double.MinValue;
        }
        //CONSTRUCTORES

        /// <summary>
        /// Constructor por defecto que inicializa el atributo numero con el valor 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Constructor que inicializa el atributo con el valor pasado por parametro
        /// </summary>
        /// <param name="numero"> Valor (double) a asignar</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor que inicializa el atributo con el valor pasado por parametro
        /// </summary>
        /// <param name="strNumero"> (string) Valor a asignar</param>
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        //VALIDADORES
        /// <summary>
        /// Valida que el operando pasado por parametro sea numerico
        /// </summary>
        /// <param name="strNumero">Operando a validar (string)</param>
        /// <returns> (double) Retorna el operando si pudo y 0 si no lo logro </returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;

            if (double.TryParse(strNumero, out retorno))
            {
                return retorno;
            }
            return retorno;
        }
        /// <summary>
        /// Valida que la cadena pasada por parametro este compuesta solo por numeros binarios
        /// </summary>
        /// <param name="binario">(string) Cadena a validar</param>
        /// <returns>(bool) Retrona false si la cadena contiene algun digito que no sea binario y true si no </returns>
        private bool EsBinario(string binario)
        {
            foreach (char caracterAValidar in binario)
            {
                if (caracterAValidar != '1' && caracterAValidar != '0')
                {
                    return false;
                }
            }
            return true;
        }

        //CONVERSIONES

        /// <summary>
        /// Convierte la cadena binaria pasada por parametro a decimal
        /// </summary>
        /// <param name="binario">(String) Cadena a convertir</param>
        /// <returns>(string) Retorna la cadena converttida a decimal si pudo y "Valor invalido" si no lo logro </returns>
        public string BinarioDecimal(string binario)
        {
            string retorno;
            int digitoInt;
            int numeroDecimal = 0;
            int exponente = binario.Length - 1;

            if (binario is not null && EsBinario(binario))
            {
                //Recorro el binario y voy sacando un digito y lo almaceno en digiti
                foreach (char digito in binario)
                {
                    //Parseo el digito a int
                    digitoInt = int.Parse((digito).ToString());
                    //Hago la conversion
                    numeroDecimal =+ digitoInt * (int)Math.Pow(2, exponente);
                    exponente--;
                }

                retorno = numeroDecimal.ToString();
            }
            else
            {
                retorno = "Valor invalido";
            }
            return retorno;
        }
        /// <summary>
        /// Convierte el numero pasado por parametro a binario
        /// </summary>
        /// <param name="numero">(double) Numero a convertir </param>
        /// <returns>(string) Retorna el numero en binario si pudo y "Valor invalido" si no lo logro</returns>
        public string DecimalBinario(double numero)
        {
            string binario = "";
            int numeroEntero = (int)numero;
            if (numero > 0)
            {
                //mayor a cero para que te tome hasta el 1
                while (numeroEntero > 0)
                {
                    binario = (numeroEntero % 2).ToString() + binario;
                    numeroEntero = numeroEntero / 2;
                }
            }
            else
            {
                binario = "Valor Invalido";
            }
            return binario;
        }
        /// <summary>
        /// Es una sobrecarga.Convierte el numero pasado por parametro a binario
        /// </summary>
        /// <param name="numero">(string) Numero a convertir </param>
        /// <returns>(string) Retorna el numero en binario si pudo y "Valor invalido" si no lo logro</returns>
        public string DecimalBinario(string numero)
        {
            double numero2;
            if (double.TryParse(numero, out numero2))
            {
                return DecimalBinario(numero2);
            }
            return "Valor Invalido";
        }
    }
}
