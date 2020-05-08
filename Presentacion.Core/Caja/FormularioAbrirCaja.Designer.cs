namespace Presentacion.Core.Caja
{
    partial class FormularioAbrirCaja
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.nudMontoApertura = new System.Windows.Forms.NumericUpDown();
            this.montoLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreUsuarioLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoApertura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(158, 102);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(120, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // nudMontoApertura
            // 
            this.nudMontoApertura.Location = new System.Drawing.Point(158, 54);
            this.nudMontoApertura.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudMontoApertura.Name = "nudMontoApertura";
            this.nudMontoApertura.Size = new System.Drawing.Size(120, 20);
            this.nudMontoApertura.TabIndex = 1;
            // 
            // montoLbl
            // 
            this.montoLbl.AutoSize = true;
            this.montoLbl.Location = new System.Drawing.Point(67, 56);
            this.montoLbl.Name = "montoLbl";
            this.montoLbl.Size = new System.Drawing.Size(37, 13);
            this.montoLbl.TabIndex = 2;
            this.montoLbl.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // nombreUsuarioLbl
            // 
            this.nombreUsuarioLbl.AutoSize = true;
            this.nombreUsuarioLbl.Location = new System.Drawing.Point(155, 164);
            this.nombreUsuarioLbl.Name = "nombreUsuarioLbl";
            this.nombreUsuarioLbl.Size = new System.Drawing.Size(35, 13);
            this.nombreUsuarioLbl.TabIndex = 5;
            this.nombreUsuarioLbl.Text = "label3";
            // 
            // FormularioAbrirCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 240);
            this.Controls.Add(this.nombreUsuarioLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.montoLbl);
            this.Controls.Add(this.nudMontoApertura);
            this.Controls.Add(this.btnAbrir);
            this.Name = "FormularioAbrirCaja";
            this.Text = "AbrirCaja";
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoApertura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.NumericUpDown nudMontoApertura;
        private System.Windows.Forms.Label montoLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombreUsuarioLbl;
    }
}