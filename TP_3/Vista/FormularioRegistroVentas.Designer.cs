namespace Vista
{
    partial class FormularioRegistroVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRegistroVentas));
            this.lstRegistro = new System.Windows.Forms.ListBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnMostrarInformacion = new System.Windows.Forms.Button();
            this.btnFiltrarFecha = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPedidosEliminados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRegistro
            // 
            this.lstRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRegistro.ColumnWidth = 3;
            this.lstRegistro.FormattingEnabled = true;
            this.lstRegistro.ItemHeight = 15;
            this.lstRegistro.Location = new System.Drawing.Point(12, 51);
            this.lstRegistro.Name = "lstRegistro";
            this.lstRegistro.Size = new System.Drawing.Size(756, 349);
            this.lstRegistro.TabIndex = 0;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(12, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(227, 23);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnMostrarInformacion
            // 
            this.btnMostrarInformacion.Location = new System.Drawing.Point(778, 51);
            this.btnMostrarInformacion.Name = "btnMostrarInformacion";
            this.btnMostrarInformacion.Size = new System.Drawing.Size(145, 53);
            this.btnMostrarInformacion.TabIndex = 2;
            this.btnMostrarInformacion.Text = "Mostrar Informacion";
            this.btnMostrarInformacion.UseVisualStyleBackColor = true;
            this.btnMostrarInformacion.Click += new System.EventHandler(this.btnMostrarInformacion_Click);
            // 
            // btnFiltrarFecha
            // 
            this.btnFiltrarFecha.Location = new System.Drawing.Point(778, 128);
            this.btnFiltrarFecha.Name = "btnFiltrarFecha";
            this.btnFiltrarFecha.Size = new System.Drawing.Size(145, 53);
            this.btnFiltrarFecha.TabIndex = 3;
            this.btnFiltrarFecha.Text = "Filtrar Por Fecha";
            this.btnFiltrarFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarFecha.Click += new System.EventHandler(this.btnFiltrarFecha_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(778, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 53);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Pedido";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPedidosEliminados
            // 
            this.btnPedidosEliminados.Location = new System.Drawing.Point(778, 279);
            this.btnPedidosEliminados.Name = "btnPedidosEliminados";
            this.btnPedidosEliminados.Size = new System.Drawing.Size(145, 53);
            this.btnPedidosEliminados.TabIndex = 5;
            this.btnPedidosEliminados.Text = "Registro de Pedidos Eliminados";
            this.btnPedidosEliminados.UseVisualStyleBackColor = true;
            this.btnPedidosEliminados.Click += new System.EventHandler(this.btnPedidosEliminados_Click);
            // 
            // FormularioRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 416);
            this.Controls.Add(this.btnPedidosEliminados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnFiltrarFecha);
            this.Controls.Add(this.btnMostrarInformacion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lstRegistro);
            this.Name = "FormularioRegistroVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.FormularioRegistroVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRegistro;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnMostrarInformacion;
        private System.Windows.Forms.Button btnFiltrarFecha;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPedidosEliminados;
    }
}