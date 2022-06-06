using System;
using System.Collections.Generic;
using System.Text;


namespace Biblioteca
{
    public abstract class Producto
    {
        protected string tipo;
        protected double precio;
        protected int cantidad;
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
        public Producto(string tipo, double precio,int cantidad)
        {
            this.tipo = tipo;
            Precio = precio;
            this.cantidad = cantidad;   
        }
        internal abstract string MostrarInformacionParticular();
        public virtual string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: {this.tipo}");
            sb.Append($"{MostrarInformacionParticular()}");
            sb.AppendLine($"Precio: {this.Precio}");
            return sb.ToString();
        }
        public static bool operator +(Pedido pedido, Producto productoNuevo)
        {
            if (pedido is not null && productoNuevo is not null)
            {
                pedido.ListaProductos.Add(productoNuevo);
                return true;
            }
            return false;
        }
    }
}
