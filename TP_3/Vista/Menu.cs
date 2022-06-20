using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class Menu : Form
    {
        public static List<Pedido>? listaPedidos;
        public Menu()
        {
            InitializeComponent();
            listaPedidos = new List<Pedido>();
        }
        public static List<Pedido> ListaPedidos
        {
            get { return listaPedidos; }
            set 
            {
            if(value is not null)
                {
                 listaPedidos = value;
                }   
            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {
           btnRegistroVentas.Enabled = false;
        }
        private void btnRegistroVentas_Click(object sender, EventArgs e)
        {
           
            FormularioRegistroVentas formularioRegistroVentas = new FormularioRegistroVentas();
            formularioRegistroVentas.ShowDialog();
        }

        private void btnPedidoNuevo_Click(object sender, EventArgs e)
        {
            FormularioCliente formularioCliente = new FormularioCliente();
            formularioCliente.ShowDialog();
            if(ListaPedidos.Count > 0)
            {
                btnRegistroVentas.Enabled = true;
                btnCargarDatos.Enabled = false;
            }
            else
            {
                MessageBox.Show("No tiene ningun pedido guardado!!!");
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                ListaPedidos = Serializador<List<Pedido>>.LeerXml("Pedidos.xml");
                if(ListaPedidos.Count > 0)
                {
                    btnRegistroVentas.Enabled = true;
                    btnCargarDatos.Enabled = false;
                    MessageBox.Show("Se cargaron los datos con exito!!!");

                }
                else
                {
                    MessageBox.Show("No tiene ningun pedido guardado!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problemas para cargar los datos del XML");
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
