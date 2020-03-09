namespace Presentacion.Core.Provincia.Localidad
{
    partial class FormularioLocalidadABM
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
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.btnNuevaProvincia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidad.Location = new System.Drawing.Point(88, 124);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(293, 22);
            this.txtLocalidad.TabIndex = 5;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(15, 68);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(72, 20);
            this.lblProvincia.TabIndex = 4;
            this.lblProvincia.Text = "Provincia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Localidad";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(88, 68);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(244, 21);
            this.cmbProvincia.TabIndex = 20;
            // 
            // btnNuevaProvincia
            // 
            this.btnNuevaProvincia.Location = new System.Drawing.Point(340, 69);
            this.btnNuevaProvincia.Name = "btnNuevaProvincia";
            this.btnNuevaProvincia.Size = new System.Drawing.Size(41, 21);
            this.btnNuevaProvincia.TabIndex = 21;
            this.btnNuevaProvincia.Text = "...";
            this.btnNuevaProvincia.UseVisualStyleBackColor = true;
            this.btnNuevaProvincia.Click += new System.EventHandler(this.btnNuevaProvincia_Click);
            // 
            // FormularioLocalidadABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 159);
            this.Controls.Add(this.btnNuevaProvincia);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lblProvincia);
            this.MaximumSize = new System.Drawing.Size(413, 198);
            this.MinimumSize = new System.Drawing.Size(413, 198);
            this.Name = "FormularioLocalidadABM";
            this.Text = "FormularioLocalidadABM";
            this.Controls.SetChildIndex(this.lblProvincia, 0);
            this.Controls.SetChildIndex(this.txtLocalidad, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbProvincia, 0);
            this.Controls.SetChildIndex(this.btnNuevaProvincia, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Button btnNuevaProvincia;
    }
}