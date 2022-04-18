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

namespace TP_1
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        //BOTONES
        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = (FormCalculadora.Operar(this.txtNumero1.Text,this.txtNumero2.Text,cmbOperador.SelectedItem.ToString())).ToString();

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

        }
      
        //BOTON PARA SALIR
        private void FromCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Hand) == DialogResult.No){
                e.Cancel = true;
            }
        }
      //METODOS 
      private void Limpiar()
        {
            //textbox, combobox, label
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = ""; 
            this.cmbOperador.Text = string.Empty;
            this.lblResultado.Text = "";
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            char operadorChar;
            if(numero1 != null && numero2 != null && operador != null)
            {
             char.TryParse(operador, out operadorChar);
             Operando operador1 = new Operando(numero1);
             Operando operador2 = new Operando(numero2);

             return Calculadora.Operar(operador1, operador2, operadorChar);
            }
         return 0;
        }

    }
}
