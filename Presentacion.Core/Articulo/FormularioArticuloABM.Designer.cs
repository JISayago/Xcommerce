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
            this.cbxDescuentaStock = new System.Windows.Forms.CheckBox();
            this.nudStockMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxCodigoBarra = new System.Windows.Forms.TextBox();
            this.nudPrecioCosto = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudPrecioPublico = new System.Windows.Forms.NumericUpDown();
            this.btnNuevaListaPrecio = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.nudStockMin = new System.Windows.Forms.NumericUpDown();
            this.Archivo = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxPermiteStockNegativo = new System.Windows.Forms.CheckBox();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.nudLimiteVenta = new System.Windows.Forms.NumericUpDown();
            this.cbxActivarLimiteVenta = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pnlFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFotoArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioPublico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.gbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteVenta)).BeginInit();
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
            this.pnlFoto.TabIndex = 20;
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
            this.btnAgregarImagen.TabIndex = 1;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click_1);
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
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Abreviatura";
            // 
            // txtBoxAbreviatura
            // 
            this.txtBoxAbreviatura.Location = new System.Drawing.Point(86, 158);
            this.txtBoxAbreviatura.Name = "txtBoxAbreviatura";
            this.txtBoxAbreviatura.Size = new System.Drawing.Size(466, 20);
            this.txtBoxAbreviatura.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(19, 105);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 13);
            this.lblApellido.TabIndex = 28;
            this.lblApellido.Text = "Descripcion";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(86, 102);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(466, 20);
            this.txtBoxDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Detalle";
            // 
            // txtBoxDetalle
            // 
            this.txtBoxDetalle.Location = new System.Drawing.Point(86, 132);
            this.txtBoxDetalle.Name = "txtBoxDetalle";
            this.txtBoxDetalle.Size = new System.Drawing.Size(466, 20);
            this.txtBoxDetalle.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(558, 72);
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
            this.lblLegajo.TabIndex = 26;
            this.lblLegajo.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(263, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 131;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 130;
            this.label3.Text = "Codigo Barra";
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.Location = new System.Drawing.Point(511, 306);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(41, 21);
            this.btnLocalidad.TabIndex = 17;
            this.btnLocalidad.Text = "...";
            this.btnLocalidad.UseVisualStyleBackColor = true;
            this.btnLocalidad.Click += new System.EventHandler(this.btnLocalidad_Click);
            // 
            // btnNuevaProvincia
            // 
            this.btnNuevaProvincia.Location = new System.Drawing.Point(511, 279);
            this.btnNuevaProvincia.Name = "btnNuevaProvincia";
            this.btnNuevaProvincia.Size = new System.Drawing.Size(41, 21);
            this.btnNuevaProvincia.TabIndex = 16;
            this.btnNuevaProvincia.Text = "...";
            this.btnNuevaProvincia.UseVisualStyleBackColor = true;
            this.btnNuevaProvincia.Click += new System.EventHandler(this.btnNuevaProvincia_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Rubro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Marca";
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(61, 310);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(435, 21);
            this.cmbRubro.TabIndex = 15;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(61, 276);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(435, 21);
            this.cmbMarca.TabIndex = 14;
            // 
            // cbxDescuentaStock
            // 
            this.cbxDescuentaStock.AutoSize = true;
            this.cbxDescuentaStock.Location = new System.Drawing.Point(98, 0);
            this.cbxDescuentaStock.Name = "cbxDescuentaStock";
            this.cbxDescuentaStock.Size = new System.Drawing.Size(15, 14);
            this.cbxDescuentaStock.TabIndex = 6;
            this.cbxDescuentaStock.ThreeState = true;
            this.cbxDescuentaStock.UseVisualStyleBackColor = true;
            this.cbxDescuentaStock.CheckedChanged += new System.EventHandler(this.cbxDescuentaStock_CheckedChanged);
            // 
            // nudStockMax
            // 
            this.nudStockMax.Location = new System.Drawing.Point(282, 48);
            this.nudStockMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudStockMax.Name = "nudStockMax";
            this.nudStockMax.Size = new System.Drawing.Size(40, 20);
            this.nudStockMax.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock Máximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock Mínimo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Límite";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(86, 69);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(171, 20);
            this.txtBoxCodigo.TabIndex = 0;
            // 
            // txtBoxCodigoBarra
            // 
            this.txtBoxCodigoBarra.Location = new System.Drawing.Point(358, 70);
            this.txtBoxCodigoBarra.Name = "txtBoxCodigoBarra";
            this.txtBoxCodigoBarra.Size = new System.Drawing.Size(194, 20);
            this.txtBoxCodigoBarra.TabIndex = 1;
            // 
            // nudPrecioCosto
            // 
            this.nudPrecioCosto.Location = new System.Drawing.Point(123, 343);
            this.nudPrecioCosto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrecioCosto.Name = "nudPrecioCosto";
            this.nudPrecioCosto.Size = new System.Drawing.Size(254, 20);
            this.nudPrecioCosto.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 155;
            this.label8.Text = "Precio Costo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 157;
            this.label11.Text = "Precio Publico";
            // 
            // nudPrecioPublico
            // 
            this.nudPrecioPublico.Location = new System.Drawing.Point(123, 369);
            this.nudPrecioPublico.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrecioPublico.Name = "nudPrecioPublico";
            this.nudPrecioPublico.Size = new System.Drawing.Size(254, 20);
            this.nudPrecioPublico.TabIndex = 19;
            // 
            // btnNuevaListaPrecio
            // 
            this.btnNuevaListaPrecio.Location = new System.Drawing.Point(386, 404);
            this.btnNuevaListaPrecio.Name = "btnNuevaListaPrecio";
            this.btnNuevaListaPrecio.Size = new System.Drawing.Size(41, 21);
            this.btnNuevaListaPrecio.TabIndex = 21;
            this.btnNuevaListaPrecio.Text = "...";
            this.btnNuevaListaPrecio.UseVisualStyleBackColor = true;
            this.btnNuevaListaPrecio.Click += new System.EventHandler(this.BtnNuevaListaPrecio_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 160;
            this.label12.Text = "Lista Precio";
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(117, 404);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(260, 21);
            this.cmbListaPrecio.TabIndex = 20;
            // 
            // nudStockMin
            // 
            this.nudStockMin.Location = new System.Drawing.Point(91, 49);
            this.nudStockMin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudStockMin.Name = "nudStockMin";
            this.nudStockMin.Size = new System.Drawing.Size(40, 20);
            this.nudStockMin.TabIndex = 13;
            // 
            // Archivo
            // 
            this.Archivo.FileName = "Archivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(558, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 161;
            this.label7.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(558, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 162;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(558, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 163;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(558, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 164;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(433, 405);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 20);
            this.label16.TabIndex = 165;
            this.label16.Text = "*";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(91, 19);
            this.nudStock.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(40, 20);
            this.nudStock.TabIndex = 166;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 167;
            this.label17.Text = "Stock";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(558, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 20);
            this.label18.TabIndex = 168;
            this.label18.Text = "*";
            // 
            // cbxPermiteStockNegativo
            // 
            this.cbxPermiteStockNegativo.AutoSize = true;
            this.cbxPermiteStockNegativo.Location = new System.Drawing.Point(202, 19);
            this.cbxPermiteStockNegativo.Name = "cbxPermiteStockNegativo";
            this.cbxPermiteStockNegativo.Size = new System.Drawing.Size(138, 17);
            this.cbxPermiteStockNegativo.TabIndex = 9;
            this.cbxPermiteStockNegativo.Text = "Permite Stock Negativo";
            this.cbxPermiteStockNegativo.ThreeState = true;
            this.cbxPermiteStockNegativo.UseVisualStyleBackColor = true;
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.cbxPermiteStockNegativo);
            this.gbStock.Controls.Add(this.cbxDescuentaStock);
            this.gbStock.Controls.Add(this.nudStock);
            this.gbStock.Controls.Add(this.label17);
            this.gbStock.Controls.Add(this.label4);
            this.gbStock.Controls.Add(this.nudStockMax);
            this.gbStock.Controls.Add(this.nudStockMin);
            this.gbStock.Controls.Add(this.label5);
            this.gbStock.Controls.Add(this.nudLimiteVenta);
            this.gbStock.Controls.Add(this.cbxActivarLimiteVenta);
            this.gbStock.Controls.Add(this.label20);
            this.gbStock.Controls.Add(this.label6);
            this.gbStock.Location = new System.Drawing.Point(12, 184);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(540, 80);
            this.gbStock.TabIndex = 169;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "Descuenta stock";
            // 
            // nudLimiteVenta
            // 
            this.nudLimiteVenta.Enabled = false;
            this.nudLimiteVenta.Location = new System.Drawing.Point(444, 47);
            this.nudLimiteVenta.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLimiteVenta.Name = "nudLimiteVenta";
            this.nudLimiteVenta.Size = new System.Drawing.Size(40, 20);
            this.nudLimiteVenta.TabIndex = 7;
            // 
            // cbxActivarLimiteVenta
            // 
            this.cbxActivarLimiteVenta.AutoSize = true;
            this.cbxActivarLimiteVenta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxActivarLimiteVenta.Enabled = false;
            this.cbxActivarLimiteVenta.Location = new System.Drawing.Point(388, 19);
            this.cbxActivarLimiteVenta.Name = "cbxActivarLimiteVenta";
            this.cbxActivarLimiteVenta.Size = new System.Drawing.Size(135, 17);
            this.cbxActivarLimiteVenta.TabIndex = 5;
            this.cbxActivarLimiteVenta.Text = "Activar Limite de Venta";
            this.cbxActivarLimiteVenta.ThreeState = true;
            this.cbxActivarLimiteVenta.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(402, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Límite";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(656, 415);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 13);
            this.label25.TabIndex = 184;
            this.label25.Text = "Campos Obligatorios (*)";
            // 
            // FormularioArticuloABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 437);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNuevaListaPrecio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbListaPrecio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudPrecioPublico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudPrecioCosto);
            this.Controls.Add(this.txtBoxCodigoBarra);
            this.Controls.Add(this.txtBoxCodigo);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(800, 476);
            this.MinimumSize = new System.Drawing.Size(800, 476);
            this.Name = "FormularioArticuloABM";
            this.Text = "FormularioArticuloABM";
            this.Activated += new System.EventHandler(this.FormularioArticuloABM_Activated);
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
            this.Controls.SetChildIndex(this.txtBoxCodigo, 0);
            this.Controls.SetChildIndex(this.txtBoxCodigoBarra, 0);
            this.Controls.SetChildIndex(this.nudPrecioCosto, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.nudPrecioPublico, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.cmbListaPrecio, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.btnNuevaListaPrecio, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.gbStock, 0);
            this.Controls.SetChildIndex(this.label25, 0);
            this.pnlFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgFotoArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioPublico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteVenta)).EndInit();
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
        protected System.Windows.Forms.CheckBox cbxDescuentaStock;
        private System.Windows.Forms.NumericUpDown nudStockMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxCodigoBarra;
        private System.Windows.Forms.NumericUpDown nudPrecioCosto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudPrecioPublico;
        private System.Windows.Forms.Button btnNuevaListaPrecio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbListaPrecio;
        private System.Windows.Forms.NumericUpDown nudStockMin;
        private System.Windows.Forms.OpenFileDialog Archivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        protected System.Windows.Forms.CheckBox cbxPermiteStockNegativo;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.NumericUpDown nudLimiteVenta;
        protected System.Windows.Forms.CheckBox cbxActivarLimiteVenta;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
    }
}