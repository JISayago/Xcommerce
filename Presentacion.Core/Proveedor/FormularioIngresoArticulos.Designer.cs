namespace Presentacion.Core.Proveedor
{
    partial class FormularioIngresoArticulos
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
            this.label16 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.txtCondicionIva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArticuloNuevo = new System.Windows.Forms.Button();
            this.btnArticuloExistente = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.nudSubTotal = new System.Windows.Forms.NumericUpDown();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.cbxDescuentaCaja = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgragarAlInventario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(290, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 212;
            this.label16.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(345, 63);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(180, 20);
            this.txtTelefono.TabIndex = 208;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 213;
            this.label14.Text = "Correo Electrónico";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(417, 20);
            this.txtEmail.TabIndex = 209;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 211;
            this.label1.Text = "Contacto";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(108, 64);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.ReadOnly = true;
            this.txtContacto.Size = new System.Drawing.Size(160, 20);
            this.txtContacto.TabIndex = 207;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(29, 15);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 13);
            this.lblApellido.TabIndex = 210;
            this.lblApellido.Text = "Razon Social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(108, 12);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(417, 20);
            this.txtRazonSocial.TabIndex = 206;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(656, 12);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(116, 27);
            this.btnBuscarProveedor.TabIndex = 214;
            this.btnBuscarProveedor.Text = "Buscar Proveedor";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(533, 12);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(116, 27);
            this.btnAgregarProveedor.TabIndex = 215;
            this.btnAgregarProveedor.Text = "Agregar Proveedor";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(12, 142);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(760, 301);
            this.dgvGrilla.TabIndex = 216;
            this.dgvGrilla.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellValueChanged);
            // 
            // txtCondicionIva
            // 
            this.txtCondicionIva.Location = new System.Drawing.Point(108, 92);
            this.txtCondicionIva.Name = "txtCondicionIva";
            this.txtCondicionIva.ReadOnly = true;
            this.txtCondicionIva.Size = new System.Drawing.Size(160, 20);
            this.txtCondicionIva.TabIndex = 217;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 218;
            this.label2.Text = "Condicion Iva";
            // 
            // btnArticuloNuevo
            // 
            this.btnArticuloNuevo.Location = new System.Drawing.Point(533, 52);
            this.btnArticuloNuevo.Name = "btnArticuloNuevo";
            this.btnArticuloNuevo.Size = new System.Drawing.Size(116, 27);
            this.btnArticuloNuevo.TabIndex = 219;
            this.btnArticuloNuevo.Text = "Articulo Nuevo";
            this.btnArticuloNuevo.UseVisualStyleBackColor = true;
            this.btnArticuloNuevo.Click += new System.EventHandler(this.btnArticuloNuevo_Click);
            // 
            // btnArticuloExistente
            // 
            this.btnArticuloExistente.Location = new System.Drawing.Point(656, 52);
            this.btnArticuloExistente.Name = "btnArticuloExistente";
            this.btnArticuloExistente.Size = new System.Drawing.Size(116, 27);
            this.btnArticuloExistente.TabIndex = 220;
            this.btnArticuloExistente.Text = "Articulo Existente";
            this.btnArticuloExistente.UseVisualStyleBackColor = true;
            this.btnArticuloExistente.Click += new System.EventHandler(this.btnArticuloExistente_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Location = new System.Drawing.Point(281, 523);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(172, 36);
            this.btnRegistrar.TabIndex = 227;
            this.btnRegistrar.Text = "Registrar ";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Enabled = false;
            this.nudTotal.InterceptArrowKeys = false;
            this.nudTotal.Location = new System.Drawing.Point(701, 532);
            this.nudTotal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.ReadOnly = true;
            this.nudTotal.Size = new System.Drawing.Size(70, 20);
            this.nudTotal.TabIndex = 226;
            this.nudTotal.ThousandsSeparator = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(616, 528);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 24);
            this.lblTotal.TabIndex = 225;
            this.lblTotal.Text = "TOTAL";
            // 
            // nudDescuento
            // 
            this.nudDescuento.Location = new System.Drawing.Point(702, 494);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(70, 20);
            this.nudDescuento.TabIndex = 224;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(537, 490);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(144, 24);
            this.lblDescuento.TabIndex = 223;
            this.lblDescuento.Text = "Descuento [%]";
            // 
            // nudSubTotal
            // 
            this.nudSubTotal.DecimalPlaces = 2;
            this.nudSubTotal.Enabled = false;
            this.nudSubTotal.InterceptArrowKeys = false;
            this.nudSubTotal.Location = new System.Drawing.Point(701, 460);
            this.nudSubTotal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudSubTotal.Name = "nudSubTotal";
            this.nudSubTotal.ReadOnly = true;
            this.nudSubTotal.Size = new System.Drawing.Size(70, 20);
            this.nudSubTotal.TabIndex = 222;
            this.nudSubTotal.ThousandsSeparator = true;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(587, 456);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(100, 24);
            this.lblSubTotal.TabIndex = 221;
            this.lblSubTotal.Text = "Sub-Total";
            // 
            // cbxDescuentaCaja
            // 
            this.cbxDescuentaCaja.AutoSize = true;
            this.cbxDescuentaCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDescuentaCaja.Location = new System.Drawing.Point(12, 449);
            this.cbxDescuentaCaja.Name = "cbxDescuentaCaja";
            this.cbxDescuentaCaja.Size = new System.Drawing.Size(164, 24);
            this.cbxDescuentaCaja.TabIndex = 228;
            this.cbxDescuentaCaja.Text = "Descuenta de Caja";
            this.cbxDescuentaCaja.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 229;
            this.label3.Text = "Ingreso Artículos";
            // 
            // btnAgragarAlInventario
            // 
            this.btnAgragarAlInventario.Location = new System.Drawing.Point(533, 92);
            this.btnAgragarAlInventario.Name = "btnAgragarAlInventario";
            this.btnAgragarAlInventario.Size = new System.Drawing.Size(239, 41);
            this.btnAgragarAlInventario.TabIndex = 230;
            this.btnAgragarAlInventario.Text = "Agregar al Inventario";
            this.btnAgragarAlInventario.UseVisualStyleBackColor = true;
            this.btnAgragarAlInventario.Click += new System.EventHandler(this.btnAgragarAlInventario_Click);
            // 
            // FormularioIngresoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAgragarAlInventario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDescuentaCaja);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.nudTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.nudDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.nudSubTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.btnArticuloExistente);
            this.Controls.Add(this.btnArticuloNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCondicionIva);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtRazonSocial);
            this.Name = "FormularioIngresoArticulos";
            this.Text = "FormularioIngresoArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        protected System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.TextBox txtCondicionIva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArticuloNuevo;
        private System.Windows.Forms.Button btnArticuloExistente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.NumericUpDown nudSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.CheckBox cbxDescuentaCaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgragarAlInventario;
    }
}