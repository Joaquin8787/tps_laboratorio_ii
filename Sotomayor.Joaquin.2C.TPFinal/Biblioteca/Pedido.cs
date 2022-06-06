using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
 
    public class Pedido
    {
        private List<Producto> listaProductos;
        private string nombre;
        private string direccion;
        private string numeroTelefono;
        private double precioFinal = 0;

        public List<Producto> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set 
            {
                if (ValidadorDireccion(value))
                {
                    direccion = value;
                }
            }
        }
        public string NumeroTelefono
        {
            get { return numeroTelefono; }
            set
            {
                if (ValidadorNumeroTelefono(value))
                {
                    numeroTelefono = value;
                }
            }
        }
        private bool ValidadorNumeroTelefono(string numeroTelefono)
        {
            if (numeroTelefono is not null)
            {
                foreach(char caracter in numeroTelefono)
                {
                    if(!(caracter >= '0' && caracter <= '9'))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        private bool ValidadorDireccion(string direccion)
        {
            if (direccion is not null)
            {
                foreach (char caracter in direccion)
                {
                    if (!(caracter >= 'A' && caracter <= 'z') && !(caracter >= '0' && caracter <= '9') && caracter != ' ')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public Pedido(string nombre, string direccion, string numeroTelefono)
        {
            this.listaProductos = new List<Producto>();
            this.nombre = nombre;
            this.Direccion = direccion;
            this.NumeroTelefono = numeroTelefono;
        }
        public static bool operator + (List<Pedido> listaPedidos, Pedido pedidoNuevo)
        {
            if(listaPedidos is not null && pedidoNuevo is not null)
            {
                       listaPedidos.Add(pedidoNuevo);
                       return true;
            }
            return false;
        }
        public static double GeneradorPrecioFinal(List<Producto> listaProducto)
        {
            double precioFinal = 0;
            if(listaProducto is not null)
            {
                foreach (Producto producto in listaProducto)
                {
                    precioFinal += (producto.Precio * producto.Cantidad);
                }
            }
            return precioFinal;
        }
        public string MostrarInformacionPedido()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre contacto: {this.nombre}");
            sb.AppendLine($"Direccion: {this.Direccion}");
            sb.AppendLine($"Numero telefonico: {this.NumeroTelefono}");
            return sb.ToString();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre contacto: {this.nombre}");
            sb.AppendLine($"Direccion: {this.Direccion}");
            sb.AppendLine($"Numero telefonico: {this.NumeroTelefono}");
            sb.AppendLine($"-------------------------------------------");
            foreach (Producto producto in this.ListaProductos)
            {
                sb.Append(producto.MostrarInformacion());
                sb.AppendLine($"-------------------------------------------");
            }
            this.precioFinal = GeneradorPrecioFinal(this.ListaProductos);
            sb.AppendLine($"Precio final: {this.precioFinal}");
        
            return sb.ToString();
        }
    }
}