namespace Presentacion.Core.Provincia
{
    partial class FormularioProvinciaABM
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
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(59, 103);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(101, 25);
            this.lblProvincia.TabIndex = 2;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincia.Location = new System.Drawing.Point(199, 104);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(213, 26);
            this.txtProvincia.TabIndex = 3;
            // 
            // FormularioProvinciaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 175);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.lblProvincia);
            this.MaximumSize = new System.Drawing.Size(498, 214);
            this.MinimumSize = new System.Drawing.Size(498, 214);
            this.Name = "FormularioProvinciaABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioProvinciaABM";
            this.Controls.SetChildIndex(this.lblProvincia, 0);
            this.Controls.SetChildIndex(this.txtProvincia, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtProvincia;
    }
}