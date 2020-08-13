namespace Presentacion.Core.Articulo.MotivoBaja
{
    partial class FormularioMotivoBajaABM
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
            this.txtMotivoBaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMotivoBaja
            // 
            this.txtMotivoBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoBaja.Location = new System.Drawing.Point(109, 68);
            this.txtMotivoBaja.MaxLength = 250;
            this.txtMotivoBaja.Name = "txtMotivoBaja";
            this.txtMotivoBaja.Size = new System.Drawing.Size(237, 22);
            this.txtMotivoBaja.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Motivo Baja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(352, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 162;
            this.label7.Text = "*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(251, 95);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 13);
            this.label25.TabIndex = 184;
            this.label25.Text = "Campos Obligatorios (*)";
            // 
            // FormularioMotivoBajaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 111);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotivoBaja);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(385, 150);
            this.MinimumSize = new System.Drawing.Size(385, 150);
            this.Name = "FormularioMotivoBajaABM";
            this.Text = "FormularioMotivoBajaABM";
            this.Controls.SetChildIndex(this.txtMotivoBaja, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label25, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMotivoBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label25;
    }
}