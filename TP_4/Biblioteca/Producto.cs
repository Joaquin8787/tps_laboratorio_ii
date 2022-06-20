using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace Biblioteca
{
    [XmlInclude(typeof(Sushi))]
    [XmlInclude(typeof(Dumpling))]
    public abstract class Producto
    {
        protected string tipo;
        protected double precio;
        protected int cantidad;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public double Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
            }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value > 0)
                {
                    cantidad = value;
                }
            }
        }
        public Producto()
        {

        }
        public Producto(string tipo, double precio,int cantidad)
        {
            this.Tipo = tipo;
            Precio = precio;
            this.Cantidad = cantidad;   
        }
        internal abstract string MostrarInformacionParticular();
        public virtual string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: {this.Tipo}");
            sb.Append($"{MostrarInformacionParticular()}");
            sb.AppendLine($"Precio Unidad: {this.Precio}");
            return sb.ToString();
        }
        public static bool operator +(Pedido pedido, Producto productoNuevo)
        {
            if (pedido is not null && productoNuevo is not null)
            {
                pedido.ListaProductos.Add(productoNuevo);
                pedido.PrecioFinal = Pedido.GeneradorPrecioFinal(pedido.ListaProductos);
                return true;
            }
            return false;
        }
        
    }

}
