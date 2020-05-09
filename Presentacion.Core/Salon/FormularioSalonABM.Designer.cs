namespace Presentacion.Core.Salon
{
    partial class FormularioSalonABM
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
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.btnNuevaListaPrecio = new System.Windows.Forms.Button();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.lblListaPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalon
            // 
            this.txtSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalon.Location = new System.Drawing.Point(142, 103);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(260, 26);
            this.txtSalon.TabIndex = 5;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(43, 104);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(67, 25);
            this.lblProvincia.TabIndex = 4;
            this.lblProvincia.Text = "Salon";
            // 
            // btnNuevaListaPrecio
            // 
            this.btnNuevaListaPrecio.Location = new System.Drawing.Point(361, 155);
            this.btnNuevaListaPrecio.Name = "btnNuevaListaPrecio";
            this.btnNuevaListaPrecio.Size = new System.Drawing.Size(41, 23);
            this.btnNuevaListaPrecio.TabIndex = 24;
            this.btnNuevaListaPrecio.Text = "...";
            this.btnNuevaListaPrecio.UseVisualStyleBackColor = true;
            this.btnNuevaListaPrecio.Click += new System.EventHandler(this.btnNuevaListaPrecio_Click);
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(142, 155);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(213, 21);
            this.cmbListaPrecio.TabIndex = 23;
            // 
            // lblListaPrecio
            // 
            this.lblListaPrecio.AutoSize = true;
            this.lblListaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPrecio.Location = new System.Drawing.Point(14, 156);
            this.lblListaPrecio.Name = "lblListaPrecio";
            this.lblListaPrecio.Size = new System.Drawing.Size(91, 20);
            this.lblListaPrecio.TabIndex = 22;
            this.lblListaPrecio.Text = "Lista Precio";
            // 
            // FormularioSalonABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 208);
            this.Controls.Add(this.btnNuevaListaPrecio);
            this.Controls.Add(this.cmbListaPrecio);
            this.Controls.Add(this.lblListaPrecio);
            this.Controls.Add(this.txtSalon);
            this.Controls.Add(this.lblProvincia);
            this.Name = "FormularioSalonABM";
            this.Text = "FormularioSalonABM";
            this.Controls.SetChildIndex(this.lblProvincia, 0);
            this.Controls.SetChildIndex(this.txtSalon, 0);
            this.Controls.SetChildIndex(this.lblListaPrecio, 0);
            this.Controls.SetChildIndex(this.cmbListaPrecio, 0);
            this.Controls.SetChildIndex(this.btnNuevaListaPrecio, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Button btnNuevaListaPrecio;
        private System.Windows.Forms.ComboBox cmbListaPrecio;
        private System.Windows.Forms.Label lblListaPrecio;
    }
}