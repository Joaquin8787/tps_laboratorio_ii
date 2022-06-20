using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;
using Biblioteca;

namespace Vista
{
    public partial class FormularioPedido : Form
    {
        private Pedido pedidoNuevo = FormularioCliente.PedidoNuevo;
        public FormularioPedido()
        {
            InitializeComponent();
        }
       
        private void FormularioPedido_Load(object sender, EventArgs e)
        {
            cmbTipo.Enabled = false;
            btnCrear.Enabled = false;
            rtbPedidos.Text = pedidoNuevo.MostrarInformacionCliente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cmbProducto.SelectedItem is not null && cmbTipo.SelectedItem is not null && cmbCantidad.SelectedItem is not null)
            {
                if (cmbProducto.Text == "Sushi")
                {
                    Producto producto = new Sushi((string)cmbProducto.SelectedItem, Sushi.GeneradorPrecio((Roll)cmbTipo.SelectedItem), int.Parse(cmbCantidad.Text),(Roll)cmbTipo.SelectedItem);
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
                    Producto producto = new Dumpling((string)cmbProducto.SelectedItem, Dumpling.GeneradorPrecio((Relleno)cmbTipo.SelectedItem), int.Parse(cmbCantidad.Text),(Relleno)cmbTipo.SelectedItem);
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

                rtbPedidos.Text = pedidoNuevo.MostrarInformacion();
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
            try
            {
                if (Menu.ListaPedidos + pedidoNuevo)
                {
                    Serializador<List<Pedido>>.GuardarXml(Menu.ListaPedidos,"Pedidos.xml",false);
                    MessageBox.Show("Pedido generado con exito", "Atencion finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo algun problema para generar el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Se ha encontrado una excepcion");
            }
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
          Limpiar();
          rtbPedidos.Text = pedidoNuevo.MostrarInformacionCliente();
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
