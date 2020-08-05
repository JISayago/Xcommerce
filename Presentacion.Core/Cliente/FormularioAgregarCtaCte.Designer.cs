namespace Presentacion.Core.Cliente
{
    partial class FormularioAgregarCtaCte
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
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtAgregarSaldo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btndeshacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoActual.Location = new System.Drawing.Point(87, 68);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(107, 18);
            this.lblSaldoActual.TabIndex = 0;
            this.lblSaldoActual.Text = "Saldo Actual:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(60, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 16);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtAgregarSaldo
            // 
            this.txtAgregarSaldo.Location = new System.Drawing.Point(12, 33);
            this.txtAgregarSaldo.Name = "txtAgregarSaldo";
            this.txtAgregarSaldo.Size = new System.Drawing.Size(113, 20);
            this.txtAgregarSaldo.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(131, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 25);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Saldo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btndeshacer
            // 
            this.btndeshacer.Location = new System.Drawing.Point(221, 30);
            this.btndeshacer.Name = "btndeshacer";
            this.btndeshacer.Size = new System.Drawing.Size(57, 25);
            this.btndeshacer.TabIndex = 4;
            this.btndeshacer.Text = "Cancelar";
            this.btndeshacer.UseVisualStyleBackColor = true;
            this.btndeshacer.Click += new System.EventHandler(this.btndeshacer_Click);
            // 
            // FormularioAgregarCtaCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 93);
            this.Controls.Add(this.btndeshacer);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAgregarSaldo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblSaldoActual);
            this.Name = "FormularioAgregarCtaCte";
            this.Text = "FormularioAgregarCtaCte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtAgregarSaldo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btndeshacer;
    }
}