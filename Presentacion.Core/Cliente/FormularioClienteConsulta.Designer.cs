namespace Presentacion.Core.Cliente
{
    partial class FormularioClienteConsulta
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
            this.brnAgregarSaldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brnAgregarSaldo
            // 
            this.brnAgregarSaldo.Location = new System.Drawing.Point(254, 3);
            this.brnAgregarSaldo.Name = "brnAgregarSaldo";
            this.brnAgregarSaldo.Size = new System.Drawing.Size(106, 34);
            this.brnAgregarSaldo.TabIndex = 128;
            this.brnAgregarSaldo.Text = "Agregar Saldo a Cta.Cte.";
            this.brnAgregarSaldo.UseVisualStyleBackColor = true;
            this.brnAgregarSaldo.Click += new System.EventHandler(this.brnAgregarSaldo_Click);
            // 
            // FormularioClienteConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.brnAgregarSaldo);
            this.Name = "FormularioClienteConsulta";
            this.Text = "FormularioClienteConsulta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormularioClienteConsulta_FormClosed);
            
            this.Controls.SetChildIndex(this.cbxEstaEliminado, 0);
            this.Controls.SetChildIndex(this.brnAgregarSaldo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnAgregarSaldo;
    }
}