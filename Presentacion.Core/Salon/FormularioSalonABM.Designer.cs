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
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalon
            // 
            this.txtSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalon.Location = new System.Drawing.Point(132, 65);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(260, 26);
            this.txtSalon.TabIndex = 5;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(33, 66);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(67, 25);
            this.lblProvincia.TabIndex = 4;
            this.lblProvincia.Text = "Salon";
            // 
            // btnNuevaListaPrecio
            // 
            this.btnNuevaListaPrecio.Location = new System.Drawing.Point(351, 117);
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
            this.cmbListaPrecio.Location = new System.Drawing.Point(132, 117);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(213, 21);
            this.cmbListaPrecio.TabIndex = 23;
            // 
            // lblListaPrecio
            // 
            this.lblListaPrecio.AutoSize = true;
            this.lblListaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPrecio.Location = new System.Drawing.Point(4, 118);
            this.lblListaPrecio.Name = "lblListaPrecio";
            this.lblListaPrecio.Size = new System.Drawing.Size(91, 20);
            this.lblListaPrecio.TabIndex = 22;
            this.lblListaPrecio.Text = "Lista Precio";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(393, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 20);
            this.label20.TabIndex = 162;
            this.label20.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(393, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 163;
            this.label1.Text = "*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(292, 148);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 13);
            this.label25.TabIndex = 185;
            this.label25.Text = "Campos Obligatorios (*)";
            // 
            // FormularioSalonABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 170);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnNuevaListaPrecio);
            this.Controls.Add(this.cmbListaPrecio);
            this.Controls.Add(this.lblListaPrecio);
            this.Controls.Add(this.txtSalon);
            this.Controls.Add(this.lblProvincia);
            this.MaximumSize = new System.Drawing.Size(424, 209);
            this.MinimumSize = new System.Drawing.Size(424, 209);
            this.Name = "FormularioSalonABM";
            this.Text = "FormularioSalonABM";
            this.Activated += new System.EventHandler(this.FormularioSalonABM_Activated);
            this.Controls.SetChildIndex(this.lblProvincia, 0);
            this.Controls.SetChildIndex(this.txtSalon, 0);
            this.Controls.SetChildIndex(this.lblListaPrecio, 0);
            this.Controls.SetChildIndex(this.cmbListaPrecio, 0);
            this.Controls.SetChildIndex(this.btnNuevaListaPrecio, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label25, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Button btnNuevaListaPrecio;
        private System.Windows.Forms.ComboBox cmbListaPrecio;
        private System.Windows.Forms.Label lblListaPrecio;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label25;
    }
}