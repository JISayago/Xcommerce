namespace Presentacion.Core.Articulo
{
    partial class FormularioArticuloConsulta
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
            this.btnBajaArticulo = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBajaArticulo
            // 
            this.btnBajaArticulo.Location = new System.Drawing.Point(416, 6);
            this.btnBajaArticulo.Name = "btnBajaArticulo";
            this.btnBajaArticulo.Size = new System.Drawing.Size(88, 36);
            this.btnBajaArticulo.TabIndex = 128;
            this.btnBajaArticulo.Text = "Baja Stock";
            this.btnBajaArticulo.UseVisualStyleBackColor = true;
            this.btnBajaArticulo.Click += new System.EventHandler(this.btnBajaArticulo_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(327, 6);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(83, 36);
            this.btnStock.TabIndex = 129;
            this.btnStock.Text = "Alta Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // FormularioArticuloConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            //this.ClientSize = new System.Drawing.Size(1391, 838);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnBajaArticulo);
            this.Name = "FormularioArticuloConsulta";
            this.Text = "FormularioArticuloConsulta";
            this.Controls.SetChildIndex(this.cbxEstaEliminado, 0);
            this.Controls.SetChildIndex(this.btnBajaArticulo, 0);
            this.Controls.SetChildIndex(this.btnStock, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBajaArticulo;
        private System.Windows.Forms.Button btnStock;
    }
}