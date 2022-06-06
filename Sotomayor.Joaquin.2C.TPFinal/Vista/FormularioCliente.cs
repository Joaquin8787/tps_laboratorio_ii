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
    public partial class FormularioCliente : Form
    {
        private static Pedido pedidoNuevo;
        public FormularioCliente()
        {
            InitializeComponent();
        }
        
        public static Pedido PedidoNuevo
        {
            get
            {
                if(pedidoNuevo is not null)
                {
                    return pedidoNuevo;
                }
                return null;
               
            }
            set
            {
                pedidoNuevo = value;
            }
        }
        private void FormularioCliente_Load(object sender, EventArgs e)
        {
            btnAgregarProducto.Enabled = false;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtDireccion.Text) && !string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                pedidoNuevo = new Pedido(txtNombre.Text, txtDireccion.Text, txtTelefono.Text);

                if(pedidoNuevo.Direccion is null || pedidoNuevo.NumeroTelefono is null)
                {
                    MessageBox.Show("Error al ingresar los datos", "Crear Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
                else
                {
                    txtNombre.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;

                    rtbCliente.Text = pedidoNuevo.MostrarInformacionPedido();

                    MessageBox.Show("Cliente creado con exito!!!", "Crear Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAgregarProducto.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            FormularioPedido formularioPedidos = new FormularioPedido();
            formularioPedidos.ShowDialog();
            Limpiar();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtNombre.ResetText();
            txtDireccion.ResetText();
            txtTelefono.ResetText();
            rtbCliente.ResetText();
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            btnAgregarProducto.Enabled = false;

        }
        
        
       
    }
}
