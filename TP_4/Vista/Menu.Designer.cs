namespace Vista
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPedidoNuevo = new System.Windows.Forms.Button();
            this.btnRegistroVentas = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPedidoNuevo
            // 
            this.btnPedidoNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnPedidoNuevo.Location = new System.Drawing.Point(12, 78);
            this.btnPedidoNuevo.Name = "btnPedidoNuevo";
            this.btnPedidoNuevo.Size = new System.Drawing.Size(160, 55);
            this.btnPedidoNuevo.TabIndex = 23;
            this.btnPedidoNuevo.Text = "Registrar Pedido Nuevo";
            this.btnPedidoNuevo.UseVisualStyleBackColor = false;
            this.btnPedidoNuevo.Click += new System.EventHandler(this.btnPedidoNuevo_Click);
            // 
            // btnRegistroVentas
            // 
            this.btnRegistroVentas.Location = new System.Drawing.Point(12, 158);
            this.btnRegistroVentas.Name = "btnRegistroVentas";
            this.btnRegistroVentas.Size = new System.Drawing.Size(160, 55);
            this.btnRegistroVentas.TabIndex = 24;
            this.btnRegistroVentas.Text = "Registro de Ventas";
            this.btnRegistroVentas.UseVisualStyleBackColor = true;
            this.btnRegistroVentas.Click += new System.EventHandler(this.btnRegistroVentas_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.SystemColors.Control;
            this.btnCargarDatos.Location = new System.Drawing.Point(12, 241);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(160, 55);
            this.btnCargarDatos.TabIndex = 25;
            this.btnCargarDatos.Text = "Cargar Datos XML";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources._hazte_premium_descarga_alta_resolucion_designed_with_EDIT_org;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(367, 368);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnRegistroVentas);
            this.Controls.Add(this.btnPedidoNuevo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPedidoNuevo;
        private System.Windows.Forms.Button btnRegistroVentas;
        private System.Windows.Forms.Button btnCargarDatos;
    }
}