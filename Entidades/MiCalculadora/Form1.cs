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
        /// <summary>
        /// Evento del form que desabhilita los botones para convertir a binario y a decimal al iniciar la calculadora 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }
        /// <summary>
        /// Evento que muestra un mensaje al usuario y espera la confirmacion para cerrar la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //BOTONES

        /// <summary>
        /// Realiza una operacion con los numeros y operador pasados por parametros al tocar el boton, lo muestra por el label y muestra la operacion en el listBox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultado = (FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, cmbOperador.SelectedItem.ToString())).ToString();
            this.lblResultado.Text = resultado;
            this.lstOperaciones.Items.Add($"{this.txtNumero1.Text} {cmbOperador.SelectedItem.ToString()} {this.txtNumero2.Text} = {resultado}");
        }

        /// <summary>
        /// LLama a al metodo Limpiar al clickear el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        ///  Muestra un mensaje al usuario y espera la confirmacion para cerrar la calculadora al clickear el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Al clickear el boton llama al metodo para convertir a binario el resultado del label y habilita el boton para convertir a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.btnConvertirABinario.Enabled = false;
            this.lblResultado.Text = new Operando().DecimalBinario(this.lblResultado.Text);
            this.btnConvertirADecimal.Enabled = true;
        }

        /// <summary>
        /// Al clickear el boton llama al metodo para convertir a decimal el resultado del label y habilita el boton para convertir a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Limpia los textboxs, el comboBox y el listBox al clickear el boton
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lstOperaciones.Text = string.Empty;
        }
        /// <summary>
        /// Realiza una operacion con los numeros y el operador pasados por parametro, llamando al metodo Operar de la clase Calculadora
        /// </summary>
        /// <param name="numero1">(string) 1er Numero</param>
        /// <param name="numero2">(string) 2do Numero</param>
        /// <param name="operador">(string) Operador </param>
        /// <returns>(double) Retorna el resultado de la operacion si pudo y un 0 si no lo logro </returns>
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
