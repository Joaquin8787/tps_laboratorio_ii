using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{

    public class Pedido : IMostrar
    {
        private string nombre;
        private string direccion;
        private string numeroTelefono;
        private List<Producto> listaProductos;
        private double precioFinal = 0;
        private DateTime fechaYHora;
        
        //PROPIEDADES
        public string Nombre
        {
            get { return nombre; }
            set
            {
                    nombre = value;
            }
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
        public List<Producto> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }
        public double PrecioFinal
        {
            get { return precioFinal; }
            set { precioFinal = value; }
        }
        public DateTime FechaYHora
        {
            get { return fechaYHora; }
            set { fechaYHora = value; }
        }

        //VALIDADORES
        public static bool ValidadorNombre(string numeroTelefono)
        {
            if (numeroTelefono is not null)
            {
                if (Regex.IsMatch(numeroTelefono, "^[a-zA-Z] ?\\s[a-zA-Z]"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool ValidadorNumeroTelefono(string numeroTelefono)
        {
            if (numeroTelefono is not null)
            {
                if (Regex.IsMatch(numeroTelefono, "^(?:(?:00)?549?)?0?(?:11|[2368]\\d)(?:(?=\\d{0,2}15)\\d{2})??\\d{8}$"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool ValidadorDireccion(string direccion)
        {
            if (direccion is not null)
            {
                if(Regex.IsMatch(direccion, "^[a-zA-Z0-9] ?[a-zA-Z0-9' ']+\\s[0-9]{1,4}$"))
                {
                    return true;
                }
                else
                {
                    return false;
                }    
            }
            return false;
        }
        //CONSTRUCTORES
        public Pedido()
        {

        }
        public Pedido(string nombre, string direccion, string numeroTelefono)
        {
            this.ListaProductos = new List<Producto>();
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.NumeroTelefono = numeroTelefono;
        }
        //OPERADORES
        public static bool operator + (List<Pedido> listaPedidos, Pedido pedidoNuevo)
        {
            if(listaPedidos is not null && pedidoNuevo is not null)
            {
                //LE GENERO LA FECHA UNA VEZ QUE LO AGREGO A LA LISTA
                       pedidoNuevo.FechaYHora = DateTime.Now;
                       listaPedidos.Add(pedidoNuevo);
                       return true;
            }
            return false;
        }
        //GENERADOR DE PRECIO FINAL
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
        public string MostrarInformacionCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre contacto: {this.Nombre}");
            sb.AppendLine($"Direccion: {this.Direccion}");
            sb.AppendLine($"Numero telefonico: {this.NumeroTelefono}");
            return sb.ToString();
        }
        public string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.MostrarInformacionCliente());
            sb.AppendLine($"--------------------------------------------");
            foreach (Producto producto in this.ListaProductos)
            {
                sb.Append(producto.MostrarInformacion());
                sb.AppendLine($"--------------------------------------------");
            }
            sb.AppendLine($"Precio final: {this.PrecioFinal}");

            return sb.ToString();
        }
        public string MostrarConHoraYFecha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"---- PRODUCTO ELIMINADO ----");
            sb.AppendLine($"Nombre contacto: {this.Nombre} - Direccion: {this.Direccion} - Numero telefonico: {this.NumeroTelefono}");
            sb.AppendLine($"--------------------------------------------");
            foreach (Producto producto in this.ListaProductos)
            {
                sb.Append(producto.MostrarInformacion());
                sb.AppendLine($"--------------------------------------------");
            }
            sb.AppendLine($"Precio final: {this.PrecioFinal}");
            sb.AppendLine($"Fecha y Hora: {this.FechaYHora}");
            return sb.ToString();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto producto in this.ListaProductos)
            {
                sb.Append($"Producto: {producto.GetType().Name} - Cantidad: {producto.Cantidad} || ");
            }
            sb.Append($"Precio Final: {this.PrecioFinal} - Fecha y Hora: {this.FechaYHora}\n");
            return sb.ToString();
        }
       
    }
}