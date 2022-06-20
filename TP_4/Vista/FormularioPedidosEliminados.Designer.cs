namespace Vista
{
    partial class FormularioPedidosEliminados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPedidosEliminados));
            this.rtbPedidosEliminados = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbPedidosEliminados
            // 
            this.rtbPedidosEliminados.Location = new System.Drawing.Point(12, 12);
            this.rtbPedidosEliminados.Name = "rtbPedidosEliminados";
            this.rtbPedidosEliminados.Size = new System.Drawing.Size(527, 426);
            this.rtbPedidosEliminados.TabIndex = 0;
            this.rtbPedidosEliminados.Text = "";
            // 
            // FormularioPedidosEliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.rtbPedidosEliminados);
            this.Name = "FormularioPedidosEliminados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos Eliminados";
            this.Load += new System.EventHandler(this.FormularioPedidosEliminados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPedidosEliminados;
    }
}