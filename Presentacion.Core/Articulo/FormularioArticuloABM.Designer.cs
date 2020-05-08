namespace Presentacion.Core.Articulo
{
    partial class FormularioArticuloABM
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
            this.pnlFoto = new System.Windows.Forms.Panel();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblTituloFoto = new System.Windows.Forms.Label();
            this.imgFotoArticulo = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxAbreviatura = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDetalle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLocalidad = new System.Windows.Forms.Button();
            this.btnNuevaProvincia = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cbxActivarLimiteVenta = new System.Windows.Forms.CheckBox();
            this.cbxDescuentaStock = new System.Windows.Forms.CheckBox();
            this.cbxPermiteStockNegativo = new System.Windows.Forms.CheckBox();
            this.nudStockMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudStockMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudLimiteVenta = new System.Windows.Forms.NumericUpDown();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxCodigoBarra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.pnlFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFotoArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFoto
            // 
            this.pnlFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlFoto.Controls.Add(this.btnAgregarImagen);
            this.pnlFoto.Controls.Add(this.lblTituloFoto);
            this.pnlFoto.Controls.Add(this.imgFotoArticulo);
            this.pnlFoto.Location = new System.Drawing.Point(579, 77);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(193, 250);
            this.pnlFoto.TabIndex = 24;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarImagen.Location = new System.Drawing.Point(8, 204);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(176, 38);
            this.btnAgregarImagen.TabIndex = 0;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lblTituloFoto
            // 
            this.lblTituloFoto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTituloFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFoto.ForeColor = System.Drawing.Color.Black;
            this.lblTituloFoto.Location = new System.Drawing.Point(0, 0);
            this.lblTituloFoto.Name = "lblTituloFoto";
            this.lblTituloFoto.Size = new System.Drawing.Size(193, 31);
            this.lblTituloFoto.TabIndex = 1;
            this.lblTituloFoto.Text = "Foto";
            this.lblTituloFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgFotoArticulo
            // 
            this.imgFotoArticulo.BackColor = System.Drawing.Color.White;
            this.imgFotoArticulo.Location = new System.Drawing.Point(8, 38);
            this.imgFotoArticulo.Name = "imgFotoArticulo";
            this.imgFotoArticulo.Size = new System.Drawing.Size(176, 158);
            this.imgFotoArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFotoArticulo.TabIndex = 0;
            this.imgFotoArticulo.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 161);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 13);
            this.lblNombre.TabIndex = 51;
            this.lblNombre.Text = "Abreviatura";
            // 
            // txtBoxAbreviatura
            // 
            this.txtBoxAbreviatura.Location = new System.Drawing.Point(88, 158);
            this.txtBoxAbreviatura.Name = "txtBoxAbreviatura";
            this.txtBoxAbreviatura.Size = new System.Drawing.Size(362, 20);
            this.txtBoxAbreviatura.TabIndex = 49;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(19, 105);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 13);
            this.lblApellido.TabIndex = 50;
            this.lblApellido.Text = "Descripcion";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(86, 102);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(362, 20);
            this.txtBoxDescripcion.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Detalle";
            // 
            // txtBoxDetalle
            // 
            this.txtBoxDetalle.Location = new System.Drawing.Point(88, 132);
            this.txtBoxDetalle.Name = "txtBoxDetalle";
            this.txtBoxDetalle.Size = new System.Drawing.Size(362, 20);
            this.txtBoxDetalle.TabIndex = 52;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(455, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 20);
            this.label19.TabIndex = 128;
            this.label19.Text = "*";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(20, 71);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(40, 13);
            this.lblLegajo.TabIndex = 127;
            this.lblLegajo.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(204, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 131;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 130;
            this.label3.Text = "Codigo Barra";
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.Location = new System.Drawing.Point(409, 369);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(41, 21);
            this.btnLocalidad.TabIndex = 137;
            this.btnLocalidad.Text = "...";
            this.btnLocalidad.UseVisualStyleBackColor = true;
            // 
            // btnNuevaProvincia
            // 
            this.btnNuevaProvincia.Location = new System.Drawing.Point(409, 342);
            this.btnNuevaProvincia.Name = "btnNuevaProvincia";
            this.btnNuevaProvincia.Size = new System.Drawing.Size(41, 21);
            this.btnNuevaProvincia.TabIndex = 135;
            this.btnNuevaProvincia.Text = "...";
            this.btnNuevaProvincia.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 139;
            this.label10.Text = "Rubro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 138;
            this.label9.Text = "Marca";
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(88, 369);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(315, 21);
            this.cmbRubro.TabIndex = 136;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(88, 342);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(315, 21);
            this.cmbMarca.TabIndex = 134;
            // 
            // cbxActivarLimiteVenta
            // 
            this.cbxActivarLimiteVenta.AutoSize = true;
            this.cbxActivarLimiteVenta.Location = new System.Drawing.Point(23, 194);
            this.cbxActivarLimiteVenta.Name = "cbxActivarLimiteVenta";
            this.cbxActivarLimiteVenta.Size = new System.Drawing.Size(135, 17);
            this.cbxActivarLimiteVenta.TabIndex = 140;
            this.cbxActivarLimiteVenta.Text = "Activar Limite de Venta";
            this.cbxActivarLimiteVenta.ThreeState = true;
            this.cbxActivarLimiteVenta.UseVisualStyleBackColor = true;
            // 
            // cbxDescuentaStock
            // 
            this.cbxDescuentaStock.AutoSize = true;
            this.cbxDescuentaStock.Location = new System.Drawing.Point(23, 268);
            this.cbxDescuentaStock.Name = "cbxDescuentaStock";
            this.cbxDescuentaStock.Size = new System.Drawing.Size(109, 17);
            this.cbxDescuentaStock.TabIndex = 141;
            this.cbxDescuentaStock.Text = "Descuenta Stock";
            this.cbxDescuentaStock.ThreeState = true;
            this.cbxDescuentaStock.UseVisualStyleBackColor = true;
            // 
            // cbxPermiteStockNegativo
            // 
            this.cbxPermiteStockNegativo.AutoSize = true;
            this.cbxPermiteStockNegativo.Location = new System.Drawing.Point(120, 319);
            this.cbxPermiteStockNegativo.Name = "cbxPermiteStockNegativo";
            this.cbxPermiteStockNegativo.Size = new System.Drawing.Size(138, 17);
            this.cbxPermiteStockNegativo.TabIndex = 142;
            this.cbxPermiteStockNegativo.Text = "Permite Stock Negativo";
            this.cbxPermiteStockNegativo.ThreeState = true;
            this.cbxPermiteStockNegativo.UseVisualStyleBackColor = true;
            // 
            // nudStockMax
            // 
            this.nudStockMax.Location = new System.Drawing.Point(323, 293);
            this.nudStockMax.Name = "nudStockMax";
            this.nudStockMax.Size = new System.Drawing.Size(40, 20);
            this.nudStockMax.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 144;
            this.label4.Text = "Stock Máximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 146;
            this.label5.Text = "Stock Mínimo";
            // 
            // nudStockMin
            // 
            this.nudStockMin.Location = new System.Drawing.Point(196, 293);
            this.nudStockMin.Name = "nudStockMin";
            this.nudStockMin.Size = new System.Drawing.Size(40, 20);
            this.nudStockMin.TabIndex = 145;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 148;
            this.label6.Text = "Límite";
            // 
            // nudLimiteVenta
            // 
            this.nudLimiteVenta.Location = new System.Drawing.Point(162, 218);
            this.nudLimiteVenta.Name = "nudLimiteVenta";
            this.nudLimiteVenta.Size = new System.Drawing.Size(40, 20);
            this.nudLimiteVenta.TabIndex = 147;
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(86, 68);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(104, 20);
            this.txtBoxCodigo.TabIndex = 150;
            // 
            // txtBoxCodigoBarra
            // 
            this.txtBoxCodigoBarra.Location = new System.Drawing.Point(323, 69);
            this.txtBoxCodigoBarra.Name = "txtBoxCodigoBarra";
            this.txtBoxCodigoBarra.Size = new System.Drawing.Size(104, 20);
            this.txtBoxCodigoBarra.TabIndex = 151;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 153;
            this.label7.Text = "Stock";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(179, 267);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(40, 20);
            this.nudStock.TabIndex = 152;
            // 
            // FormularioArticuloABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.txtBoxCodigoBarra);
            this.Controls.Add(this.txtBoxCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudLimiteVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudStockMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudStockMax);
            this.Controls.Add(this.cbxPermiteStockNegativo);
            this.Controls.Add(this.cbxDescuentaStock);
            this.Controls.Add(this.cbxActivarLimiteVenta);
            this.Controls.Add(this.btnLocalidad);
            this.Controls.Add(this.btnNuevaProvincia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbRubro);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDetalle);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxAbreviatura);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.pnlFoto);
            this.Name = "FormularioArticuloABM";
            this.Text = "FormularioArticuloABM";
            this.Controls.SetChildIndex(this.pnlFoto, 0);
            this.Controls.SetChildIndex(this.txtBoxDescripcion, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.txtBoxAbreviatura, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtBoxDetalle, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblLegajo, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbMarca, 0);
            this.Controls.SetChildIndex(this.cmbRubro, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.btnNuevaProvincia, 0);
            this.Controls.SetChildIndex(this.btnLocalidad, 0);
            this.Controls.SetChildIndex(this.cbxActivarLimiteVenta, 0);
            this.Controls.SetChildIndex(this.cbxDescuentaStock, 0);
            this.Controls.SetChildIndex(this.cbxPermiteStockNegativo, 0);
            this.Controls.SetChildIndex(this.nudStockMax, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.nudStockMin, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.nudLimiteVenta, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtBoxCodigo, 0);
            this.Controls.SetChildIndex(this.txtBoxCodigoBarra, 0);
            this.Controls.SetChildIndex(this.nudStock, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.pnlFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgFotoArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFoto;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lblTituloFoto;
        private System.Windows.Forms.PictureBox imgFotoArticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxAbreviatura;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDetalle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLocalidad;
        private System.Windows.Forms.Button btnNuevaProvincia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.ComboBox cmbMarca;
        protected System.Windows.Forms.CheckBox cbxActivarLimiteVenta;
        protected System.Windows.Forms.CheckBox cbxDescuentaStock;
        protected System.Windows.Forms.CheckBox cbxPermiteStockNegativo;
        private System.Windows.Forms.NumericUpDown nudStockMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudStockMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudLimiteVenta;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxCodigoBarra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudStock;
    }
}