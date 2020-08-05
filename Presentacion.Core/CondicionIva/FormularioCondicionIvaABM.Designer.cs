namespace Presentacion.Core.CondicionIva
{
    partial class FormularioCondicionIvaABM
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
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCondicionIva = new System.Windows.Forms.TextBox();
            this.lblCondicionIva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(272, 96);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 13);
            this.label25.TabIndex = 189;
            this.label25.Text = "Campos Obligatorios (*)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(373, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 20);
            this.label20.TabIndex = 188;
            this.label20.Text = "*";
            // 
            // txtCondicionIva
            // 
            this.txtCondicionIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicionIva.Location = new System.Drawing.Point(154, 67);
            this.txtCondicionIva.MaxLength = 250;
            this.txtCondicionIva.Name = "txtCondicionIva";
            this.txtCondicionIva.Size = new System.Drawing.Size(213, 26);
            this.txtCondicionIva.TabIndex = 187;
            // 
            // lblCondicionIva
            // 
            this.lblCondicionIva.AutoSize = true;
            this.lblCondicionIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionIva.Location = new System.Drawing.Point(6, 66);
            this.lblCondicionIva.Name = "lblCondicionIva";
            this.lblCondicionIva.Size = new System.Drawing.Size(142, 25);
            this.lblCondicionIva.TabIndex = 186;
            this.lblCondicionIva.Text = "Condicion Iva";
            // 
            // FormularioCondicionIvaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 121);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCondicionIva);
            this.Controls.Add(this.lblCondicionIva);
            this.MaximumSize = new System.Drawing.Size(404, 160);
            this.MinimumSize = new System.Drawing.Size(404, 160);
            this.Name = "FormularioCondicionIvaABM";
            this.Text = "FormularioCondicionIvaABM";
            this.Controls.SetChildIndex(this.lblCondicionIva, 0);
            this.Controls.SetChildIndex(this.txtCondicionIva, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.label25, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCondicionIva;
        private System.Windows.Forms.Label lblCondicionIva;
    }
}