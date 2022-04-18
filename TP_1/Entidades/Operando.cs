using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        //PROPIEDAD
        private string Numero
        {
            set{
                this.numero = ValidarOperando(value);
            }
        }
        //OPERADORES
        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;      
        }
        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator * (Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator / (Operando n1, Operando n2)
        {
            //Valido que no se divida por 0
            if(n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            return double.MinValue;
        }
        //CONSTRUCTORES
        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        //VALIDADORES
        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;

            if(double.TryParse(strNumero, out retorno))
            {
                return retorno;
            }
            return retorno;
        }

        private bool EsBinario(string binario)
        {
            foreach(char caracterAValidar in binario)
            {
                if(caracterAValidar != '1' && caracterAValidar != '0')
                {
                    return false;
                }
            }
            return true;
        }

        //CONVERSIONES

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
                    numeroDecimal =+ digitoInt * (int) Math.Pow(2, exponente);
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
        public string DecimalBinario(double numero)
        {
            string binario = "";
            int numeroEntero = (int)numero;
            if(numero > 0)
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
        public string DecimalBinario(string numero)
        {
            double numero2;
            if(double.TryParse(numero, out numero2))
            {
                return DecimalBinario(numero2);
            }
            return "Valor Invalido";
        }
    }
}
