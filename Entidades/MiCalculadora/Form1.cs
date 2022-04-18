using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //BOTONES
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultado = (FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, cmbOperador.SelectedItem.ToString())).ToString();
            this.lblResultado.Text = resultado;
            this.lstOperaciones.Items.Add($"{this.txtNumero1.Text} {cmbOperador.SelectedItem.ToString()} {this.txtNumero2.Text} = {resultado}");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.btnConvertirABinario.Enabled = false;
            this.lblResultado.Text = new Operando().DecimalBinario(this.lblResultado.Text);
            this.btnConvertirADecimal.Enabled = true;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.btnConvertirADecimal.Enabled = false;
            this.lblResultado.Text = new Operando().BinarioDecimal(this.lblResultado.Text);
            this.btnConvertirABinario.Enabled = true;
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //METODOS
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lstOperaciones.Text = string.Empty;
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            char operadorChar;

            if (numero1 != null && numero2 != null && operador != null)
            {
                char.TryParse(operador, out operadorChar);
                Operando operando1 = new Operando(numero1);
                Operando operando2 = new Operando(numero2);
                return Calculadora.Operar(operando1, operando2, operadorChar);
            }
            return 0;
        }
    }
}
