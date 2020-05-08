namespace Presentacion.Core.Caja
{
    partial class FormularioCerrarCaja
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
            this.nombreUsuarioLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.montoLbl = new System.Windows.Forms.Label();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreUsuarioLbl
            // 
            this.nombreUsuarioLbl.AutoSize = true;
            this.nombreUsuarioLbl.Location = new System.Drawing.Point(184, 174);
            this.nombreUsuarioLbl.Name = "nombreUsuarioLbl";
            this.nombreUsuarioLbl.Size = new System.Drawing.Size(35, 13);
            this.nombreUsuarioLbl.TabIndex = 10;
            this.nombreUsuarioLbl.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario";
            // 
            // montoLbl
            // 
            this.montoLbl.AutoSize = true;
            this.montoLbl.Location = new System.Drawing.Point(96, 66);
            this.montoLbl.Name = "montoLbl";
            this.montoLbl.Size = new System.Drawing.Size(37, 13);
            this.montoLbl.TabIndex = 8;
            this.montoLbl.Text = "Monto";
            // 
            // nudMonto
            // 
            this.nudMonto.Location = new System.Drawing.Point(187, 64);
            this.nudMonto.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(120, 20);
            this.nudMonto.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(187, 108);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FormularioCerrarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 257);
            this.Controls.Add(this.nombreUsuarioLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.montoLbl);
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormularioCerrarCaja";
            this.Text = "CerrarCaja";
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreUsuarioLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label montoLbl;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.Button btnCerrar;
    }
}