using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Relleno
    {
        Cordero, Hongos, Provoleta
    }
    public class Dumpling : Producto
    {
        protected Relleno tipoDeRelleno;
        public Relleno TipoDeRelleno
        {
            get { return tipoDeRelleno; }
            set { tipoDeRelleno = value; }
        }

        public Dumpling()
        {

        }
        public Dumpling(string tipo, double precio, int cantidad)
                : base(tipo, precio, cantidad)
            {

            }
            public Dumpling(string tipo, double precio,int cantidad, Relleno tipoDeRelleno)
                : this(tipo, precio, cantidad)
            {
                this.tipoDeRelleno = tipoDeRelleno;
            }
            internal override string MostrarInformacionParticular()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Tipo: {this.tipoDeRelleno}");
                sb.AppendLine($"Cantidad: {this.cantidad}");
                return sb.ToString();
            }
            public static double GeneradorPrecio(Relleno tipoDeRelleno)
            {
                double precio = 0;
                switch (tipoDeRelleno)
                {
                    case Relleno.Cordero:
                        {
                            precio = 135;
                        }
                        break;
                    case Relleno.Hongos:
                        {
                            precio = 120;
                        }
                        break;
                    case Relleno.Provoleta:
                        {
                            precio = 110;
                        }
                        break;
                }
                return precio;
            }
    }
}
