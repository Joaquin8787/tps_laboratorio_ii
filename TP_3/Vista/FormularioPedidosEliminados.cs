using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormularioPedidosEliminados : Form
    {
        public FormularioPedidosEliminados()
        {
            InitializeComponent();
        }

        private void FormularioPedidosEliminados_Load(object sender, EventArgs e)
        {
            rtbPedidosEliminados.Text = FormularioRegistroVentas.PedidosEliminados;
        }
    }
}
