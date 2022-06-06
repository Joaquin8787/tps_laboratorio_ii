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
    public partial class FormularioPedido : Form
    {
        public List<Pedido> listaPedidos;
        private Pedido pedidoNuevo = FormularioCliente.PedidoNuevo;

        public FormularioPedido()
        {
            InitializeComponent();
            listaPedidos = new List<Pedido>();
            
        }

        private void rtbPedidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormularioPedido_Load(object sender, EventArgs e)
        {
            cmbTipo.Enabled = false;
            btnCrear.Enabled = false;
            rtbPedidos.Text = pedidoNuevo.MostrarInformacionPedido();
        }
        private void FormularioPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cmbProducto.SelectedItem is not null && cmbTipo.SelectedItem is not null && cmbCantidad.SelectedItem is not null)
            {
                if (cmbProducto.Text == "Sushi")
                {
                    Producto producto = new Sushi((string)cmbProducto.SelectedItem, Sushi.GeneradorPrecio((Roll)cmbTipo.SelectedItem), (Roll)cmbTipo.SelectedItem, int.Parse(cmbCantidad.Text));
                    if (pedidoNuevo + producto)
                    {
                        cmbProducto.ResetText();
                        cmbTipo.ResetText();
                        cmbCantidad.ResetText();
                        cmbTipo.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(cmbProducto.Text == "Dumpling")
                {
                    Producto producto = new Dumpling((string)cmbProducto.SelectedItem, Dumpling.GeneradorPrecio((Relleno)cmbTipo.SelectedItem), (Relleno)cmbTipo.SelectedItem, int.Parse(cmbCantidad.Text));
                    if (pedidoNuevo + producto)
                    {
                        cmbProducto.ResetText();
                        cmbTipo.ResetText();
                        cmbCantidad.ResetText();
                        cmbTipo.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                rtbPedidos.Text = pedidoNuevo.ToString();
                //Activo el boton para crear el pedido
                btnCrear.Enabled = true;
            }
            else
            {
                MessageBox.Show("Complete todos los campos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipo.Items.Clear();
            cmbTipo.Enabled = true;
            if (cmbProducto.Text == "Sushi")
            {
                cmbTipo.Items.Add(Roll.Furai);
                cmbTipo.Items.Add(Roll.Parma);
                cmbTipo.Items.Add(Roll.Ibiza);
                cmbTipo.Items.Add(Roll.RollKina);
            }
            else if(cmbProducto.Text == "Dumpling")
            {
                cmbTipo.Items.Add(Relleno.Cordero);
                cmbTipo.Items.Add(Relleno.Hongos);
                cmbTipo.Items.Add(Relleno.Provoleta);
            }
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            if (listaPedidos + pedidoNuevo)
            {
                MessageBox.Show("Pedido generado con exito", "Atencion finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Hubo algun problema para generar el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
          Limpiar();
          rtbPedidos.Text = pedidoNuevo.MostrarInformacionPedido();
        }
        private void Limpiar()
        {
            cmbCantidad.ResetText();
            cmbProducto.ResetText();
            cmbTipo.ResetText();
            cmbTipo.Items.Clear();
            rtbPedidos.ResetText();
            pedidoNuevo.ListaProductos.Clear();
            cmbTipo.Enabled = false;
            btnCrear.Enabled = false;

        }
    }
}
