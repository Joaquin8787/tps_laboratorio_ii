using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Roll
    {
        RollKina,Parma,Furai,Ibiza
    }
    public class Sushi : Producto
    {

        protected Roll tipoDeRoll;

        public Sushi(string tipo, double precio,int cantidad)
            : base(tipo, precio,cantidad)
        {

        }
        public Sushi(string tipo, double precio,Roll tipoDeRoll,int cantidad)
            : this(tipo, precio, cantidad)
        {
            this.tipoDeRoll = tipoDeRoll;
        }
        internal override string MostrarInformacionParticular()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {this.tipoDeRoll}");
            sb.AppendLine($"Cantidad: {this.cantidad}");
            return sb.ToString();
        }
        public static double GeneradorPrecio(Roll tipoDeRoll)
        {
            double precio = 0;
            switch (tipoDeRoll)
            {
               case Roll.RollKina:
                    {
                      precio = 100;
                    }
               break;
               case Roll.Parma:
                    {
                      precio = 120;  
                    }
               break;
                case Roll.Furai:
                    {
                      precio = 150;
                    }
                    break;
                case Roll.Ibiza:
                    {
                      precio = 135;
                    }
                break;
        
            }
            return precio;
        }
    }
}
