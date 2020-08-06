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
            this.nombreUsuarioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.nombreUsuarioLbl.Location = new System.Drawing.Point(174, 154);
            this.nombreUsuarioLbl.Name = "nombreUsuarioLbl";
            this.nombreUsuarioLbl.Size = new System.Drawing.Size(46, 18);
            this.nombreUsuarioLbl.TabIndex = 10;
            this.nombreUsuarioLbl.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label2.Location = new System.Drawing.Point(104, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario:";
            // 
            // montoLbl
            // 
            this.montoLbl.AutoSize = true;
            this.montoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.montoLbl.Location = new System.Drawing.Point(62, 39);
            this.montoLbl.Name = "montoLbl";
            this.montoLbl.Size = new System.Drawing.Size(55, 18);
            this.montoLbl.TabIndex = 8;
            this.montoLbl.Text = "Monto:";
            // 
            // nudMonto
            // 
            this.nudMonto.Location = new System.Drawing.Point(146, 40);
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
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(65, 87);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(201, 37);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // FormularioCerrarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 213);
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