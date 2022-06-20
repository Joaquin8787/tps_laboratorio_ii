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
    public partial class FormularioRegistroVentas : Form
    {
        static string pedidosEliminados;
        public FormularioRegistroVentas()
        {
            InitializeComponent();
        }
        public static string PedidosEliminados
        {
            get { return pedidosEliminados; }
            set { pedidosEliminados = value; }
        }
        private void FormularioRegistroVentas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnMostrarInformacion_Click(object sender, EventArgs e)
        {
            Pedido? pedidoSeleccionado = lstRegistro.SelectedItem as Pedido;
            if (pedidoSeleccionado is not null)
            {
                MessageBox.Show(pedidoSeleccionado.MostrarInformacion(),"Informacion del Pedido",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pedido!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
                lstRegistro.Items.Clear();
                foreach (Pedido pedido in Menu.ListaPedidos)
                {
                    if (pedido.FechaYHora.Date == dtpFecha.Value.Date)
                    {
                        lstRegistro.Items.Add(pedido);
                    }
                }
                if(lstRegistro.Items.Count == 0)
                    {
                     lstRegistro.Items.Add("NO SE ENCUENTRAN PEDIDOS REGISTRADOS EN ESTA FECHA");
                    }
           
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Pedido? pedidoSeleccionado = lstRegistro.SelectedItem as Pedido;
            try
            {
                if (pedidoSeleccionado is not null)
                {
                    if (MessageBox.Show("¿Esta seguro que quiere eliminar el pedido?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        GestorArchivo.GuardarArchivo("ArchivoDePedidosEliminados.txt", pedidoSeleccionado.MostrarConHoraYFecha(), true);
                        Menu.ListaPedidos.Remove(pedidoSeleccionado);
                        CargarDatos();
                        Serializador<List<Pedido>>.GuardarXml(Menu.ListaPedidos, "Pedidos.xml", false);
                        MessageBox.Show("El pedido fue eliminado", "Eliminar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un pedido!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Se ha encontrado una expecion");
            }
           
        }

        private void btnPedidosEliminados_Click(object sender, EventArgs e)
        {
            try
            {
                PedidosEliminados = GestorArchivo.LeerArchivo("ArchivoDePedidosEliminados.txt");
                if(!string.IsNullOrWhiteSpace(PedidosEliminados))
                {
                    FormularioPedidosEliminados formularioPedidosEliminados = new FormularioPedidosEliminados();
                    formularioPedidosEliminados.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No tiene ningun pedido eliminado para poder visualizar");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo algun problema al leer el archivo");
            }
        }
        internal void CargarDatos()
        {
            try
            {
                lstRegistro.Items.Clear();
                foreach (Pedido pedido in Menu.ListaPedidos)
                {
                    lstRegistro.Items.Add(pedido);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Se encontro una excepcion");
            }
            //
        }
    }
}
