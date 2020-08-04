namespace Presentacion.Core.Precio
{
    partial class FormularioActualizarPrecio
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
            this.label11 = new System.Windows.Forms.Label();
            this.nudPrecioPublico = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPrecioCosto = new System.Windows.Forms.NumericUpDown();
            this.artLbl = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_aplicarRentabilidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioPublico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 164;
            this.label11.Text = "Precio Publico";
            // 
            // nudPrecioPublico
            // 
            this.nudPrecioPublico.Location = new System.Drawing.Point(98, 202);
            this.nudPrecioPublico.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrecioPublico.Name = "nudPrecioPublico";
            this.nudPrecioPublico.Size = new System.Drawing.Size(265, 20);
            this.nudPrecioPublico.TabIndex = 163;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 162;
            this.label8.Text = "Precio Costo";
            // 
            // nudPrecioCosto
            // 
            this.nudPrecioCosto.Location = new System.Drawing.Point(98, 176);
            this.nudPrecioCosto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrecioCosto.Name = "nudPrecioCosto";
            this.nudPrecioCosto.Size = new System.Drawing.Size(265, 20);
            this.nudPrecioCosto.TabIndex = 161;
            // 
            // artLbl
            // 
            this.artLbl.AutoSize = true;
            this.artLbl.Location = new System.Drawing.Point(11, 75);
            this.artLbl.Name = "artLbl";
            this.artLbl.Size = new System.Drawing.Size(42, 13);
            this.artLbl.TabIndex = 165;
            this.artLbl.Text = "Articulo";
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Location = new System.Drawing.Point(95, 75);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(82, 13);
            this.lblNombreArticulo.TabIndex = 166;
            this.lblNombreArticulo.Text = "Nombre Articulo";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(74, 244);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(350, 23);
            this.btnHistorial.TabIndex = 167;
            this.btnHistorial.Text = "Ver Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(80, 140);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(374, 21);
            this.cmbListaPrecio.TabIndex = 170;
            this.cmbListaPrecio.SelectionChangeCommitted += new System.EventHandler(this.CmbListaPrecio_SelectionChangeCommitted);
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(80, 109);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(374, 21);
            this.cmbArticulo.TabIndex = 168;
            this.cmbArticulo.SelectionChangeCommitted += new System.EventHandler(this.CmbArticulo_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 172;
            this.label1.Text = "Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 173;
            this.label2.Text = "Lista Precio";
            // 
            // btn_aplicarRentabilidad
            // 
            this.btn_aplicarRentabilidad.Location = new System.Drawing.Point(369, 178);
            this.btn_aplicarRentabilidad.Name = "btn_aplicarRentabilidad";
            this.btn_aplicarRentabilidad.Size = new System.Drawing.Size(85, 39);
            this.btn_aplicarRentabilidad.TabIndex = 174;
            this.btn_aplicarRentabilidad.Text = "Aplicar Rentabilidad";
            this.btn_aplicarRentabilidad.UseVisualStyleBackColor = true;
            this.btn_aplicarRentabilidad.Click += new System.EventHandler(this.Btn_aplicarRentabilidad_Click);
            // 
            // FormularioActualizarPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 284);
            this.Controls.Add(this.btn_aplicarRentabilidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbListaPrecio);
            this.Controls.Add(this.cmbArticulo);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.lblNombreArticulo);
            this.Controls.Add(this.artLbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudPrecioPublico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudPrecioCosto);
            this.Name = "FormularioActualizarPrecio";
            this.Text = "FormularioActualizarPrecio";
            this.Controls.SetChildIndex(this.nudPrecioCosto, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.nudPrecioPublico, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.artLbl, 0);
            this.Controls.SetChildIndex(this.lblNombreArticulo, 0);
            this.Controls.SetChildIndex(this.btnHistorial, 0);
            this.Controls.SetChildIndex(this.cmbArticulo, 0);
            this.Controls.SetChildIndex(this.cmbListaPrecio, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_aplicarRentabilidad, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioPublico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudPrecioPublico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPrecioCosto;
        private System.Windows.Forms.Label artLbl;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.ComboBox cmbListaPrecio;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aplicarRentabilidad;
    }
}