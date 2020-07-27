namespace Presentacion.Core.VentaSalon
{
    partial class FormularioComprobanteMesa
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
            this.components = new System.ComponentModel.Container();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.lblComensales = new System.Windows.Forms.Label();
            this.nudComensales = new System.Windows.Forms.NumericUpDown();
            this.txtMozoLegajo = new System.Windows.Forms.TextBox();
            this.lblMozo = new System.Windows.Forms.Label();
            this.txtApyNomMozo = new System.Windows.Forms.TextBox();
            this.btnBuscarMozo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.nudCantidadArticulo = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nudSubTotal = new System.Windows.Forms.NumericUpDown();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.gbxFormaPago = new System.Windows.Forms.GroupBox();
            this.rdbCheque = new System.Windows.Forms.RadioButton();
            this.rdbCtaCte = new System.Windows.Forms.RadioButton();
            this.rdbTarjeta = new System.Windows.Forms.RadioButton();
            this.rdbEfectivo = new System.Windows.Forms.RadioButton();
            this.btnCerrarMesa = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarCantidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblApynom = new System.Windows.Forms.Label();
            this.txtClienteDni = new System.Windows.Forms.TextBox();
            this.lblClienteDniu = new System.Windows.Forms.Label();
            this.lblClienteApynom = new System.Windows.Forms.Label();
            this.txtClienteApyNom = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComensales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.gbxFormaPago.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(3, 158);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(781, 288);
            this.dgvGrilla.TabIndex = 2;
            this.dgvGrilla.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGrilla_CellMouseClick_1);
            // 
            // lblComensales
            // 
            this.lblComensales.AutoSize = true;
            this.lblComensales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComensales.Location = new System.Drawing.Point(627, 2);
            this.lblComensales.Name = "lblComensales";
            this.lblComensales.Size = new System.Drawing.Size(107, 20);
            this.lblComensales.TabIndex = 3;
            this.lblComensales.Text = "Comensales";
            // 
            // nudComensales
            // 
            this.nudComensales.Location = new System.Drawing.Point(740, 2);
            this.nudComensales.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudComensales.Name = "nudComensales";
            this.nudComensales.Size = new System.Drawing.Size(36, 20);
            this.nudComensales.TabIndex = 4;
            this.nudComensales.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMozoLegajo
            // 
            this.txtMozoLegajo.Location = new System.Drawing.Point(110, 65);
            this.txtMozoLegajo.Name = "txtMozoLegajo";
            this.txtMozoLegajo.Size = new System.Drawing.Size(106, 20);
            this.txtMozoLegajo.TabIndex = 5;
            this.txtMozoLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMozoLegajo_KeyPress);
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMozo.Location = new System.Drawing.Point(0, 43);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(57, 20);
            this.lblMozo.TabIndex = 6;
            this.lblMozo.Text = "Mozo:";
            // 
            // txtApyNomMozo
            // 
            this.txtApyNomMozo.Enabled = false;
            this.txtApyNomMozo.Location = new System.Drawing.Point(377, 64);
            this.txtApyNomMozo.Name = "txtApyNomMozo";
            this.txtApyNomMozo.Size = new System.Drawing.Size(318, 20);
            this.txtApyNomMozo.TabIndex = 7;
            // 
            // btnBuscarMozo
            // 
            this.btnBuscarMozo.Location = new System.Drawing.Point(709, 65);
            this.btnBuscarMozo.Name = "btnBuscarMozo";
            this.btnBuscarMozo.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarMozo.TabIndex = 8;
            this.btnBuscarMozo.Text = "Buscar";
            this.btnBuscarMozo.UseVisualStyleBackColor = true;
            this.btnBuscarMozo.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo Barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(3, 130);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoBarras.TabIndex = 9;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(157, 105);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 20);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(160, 130);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(246, 20);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(427, 105);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(127, 20);
            this.lblPrecioUnitario.TabIndex = 14;
            this.lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Enabled = false;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(430, 130);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(124, 20);
            this.txtPrecioUnitario.TabIndex = 13;
            // 
            // nudCantidadArticulo
            // 
            this.nudCantidadArticulo.AllowDrop = true;
            this.nudCantidadArticulo.DecimalPlaces = 2;
            this.nudCantidadArticulo.Location = new System.Drawing.Point(579, 129);
            this.nudCantidadArticulo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudCantidadArticulo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadArticulo.Name = "nudCantidadArticulo";
            this.nudCantidadArticulo.Size = new System.Drawing.Size(71, 20);
            this.nudCantidadArticulo.TabIndex = 16;
            this.nudCantidadArticulo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudCantidadArticulo_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(576, 104);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(656, 129);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 20);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nudSubTotal
            // 
            this.nudSubTotal.DecimalPlaces = 2;
            this.nudSubTotal.Enabled = false;
            this.nudSubTotal.InterceptArrowKeys = false;
            this.nudSubTotal.Location = new System.Drawing.Point(705, 462);
            this.nudSubTotal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudSubTotal.Name = "nudSubTotal";
            this.nudSubTotal.ReadOnly = true;
            this.nudSubTotal.Size = new System.Drawing.Size(70, 20);
            this.nudSubTotal.TabIndex = 19;
            this.nudSubTotal.ThousandsSeparator = true;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(574, 457);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(114, 25);
            this.lblSubTotal.TabIndex = 18;
            this.lblSubTotal.Text = "Sub-Total";
            // 
            // nudDescuento
            // 
            this.nudDescuento.Location = new System.Drawing.Point(706, 496);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(70, 20);
            this.nudDescuento.TabIndex = 21;
            this.nudDescuento.ValueChanged += new System.EventHandler(this.nudDescuento_ValueChanged);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(524, 491);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(165, 25);
            this.lblDescuento.TabIndex = 20;
            this.lblDescuento.Text = "Descuento [%]";
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Enabled = false;
            this.nudTotal.InterceptArrowKeys = false;
            this.nudTotal.Location = new System.Drawing.Point(705, 534);
            this.nudTotal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.ReadOnly = true;
            this.nudTotal.Size = new System.Drawing.Size(70, 20);
            this.nudTotal.TabIndex = 23;
            this.nudTotal.ThousandsSeparator = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(603, 529);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 25);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "TOTAL";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Location = new System.Drawing.Point(77, 95);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(706, 5);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // gbxFormaPago
            // 
            this.gbxFormaPago.Controls.Add(this.rdbCheque);
            this.gbxFormaPago.Controls.Add(this.rdbCtaCte);
            this.gbxFormaPago.Controls.Add(this.rdbTarjeta);
            this.gbxFormaPago.Controls.Add(this.rdbEfectivo);
            this.gbxFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFormaPago.Location = new System.Drawing.Point(21, 457);
            this.gbxFormaPago.Name = "gbxFormaPago";
            this.gbxFormaPago.Size = new System.Drawing.Size(239, 100);
            this.gbxFormaPago.TabIndex = 25;
            this.gbxFormaPago.TabStop = false;
            this.gbxFormaPago.Text = "Formas de Pago";
            // 
            // rdbCheque
            // 
            this.rdbCheque.AutoSize = true;
            this.rdbCheque.Enabled = false;
            this.rdbCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCheque.Location = new System.Drawing.Point(151, 62);
            this.rdbCheque.Name = "rdbCheque";
            this.rdbCheque.Size = new System.Drawing.Size(83, 24);
            this.rdbCheque.TabIndex = 3;
            this.rdbCheque.Text = "Cheque";
            this.rdbCheque.UseVisualStyleBackColor = true;
            // 
            // rdbCtaCte
            // 
            this.rdbCtaCte.AutoSize = true;
            this.rdbCtaCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCtaCte.Location = new System.Drawing.Point(151, 28);
            this.rdbCtaCte.Name = "rdbCtaCte";
            this.rdbCtaCte.Size = new System.Drawing.Size(81, 24);
            this.rdbCtaCte.TabIndex = 2;
            this.rdbCtaCte.Text = "Cta.Cte";
            this.rdbCtaCte.UseVisualStyleBackColor = true;
            // 
            // rdbTarjeta
            // 
            this.rdbTarjeta.AutoSize = true;
            this.rdbTarjeta.Enabled = false;
            this.rdbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTarjeta.Location = new System.Drawing.Point(7, 63);
            this.rdbTarjeta.Name = "rdbTarjeta";
            this.rdbTarjeta.Size = new System.Drawing.Size(76, 24);
            this.rdbTarjeta.TabIndex = 1;
            this.rdbTarjeta.Text = "Tarjeta";
            this.rdbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Checked = true;
            this.rdbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEfectivo.Location = new System.Drawing.Point(7, 29);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(84, 24);
            this.rdbEfectivo.TabIndex = 0;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCerrarMesa
            // 
            this.btnCerrarMesa.Location = new System.Drawing.Point(325, 471);
            this.btnCerrarMesa.Name = "btnCerrarMesa";
            this.btnCerrarMesa.Size = new System.Drawing.Size(150, 38);
            this.btnCerrarMesa.TabIndex = 26;
            this.btnCerrarMesa.Text = "Cerrar Mesa";
            this.btnCerrarMesa.UseVisualStyleBackColor = true;
            this.btnCerrarMesa.Click += new System.EventHandler(this.btnCerrarMesa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(325, 517);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 37);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.cambiarCantidadToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(171, 48);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // cambiarCantidadToolStripMenuItem
            // 
            this.cambiarCantidadToolStripMenuItem.Name = "cambiarCantidadToolStripMenuItem";
            this.cambiarCantidadToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cambiarCantidadToolStripMenuItem.Text = "Cambiar Cantidad";
            this.cambiarCantidadToolStripMenuItem.Click += new System.EventHandler(this.cambiarCantidadToolStripMenuItem_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(0, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 20);
            this.lblCliente.TabIndex = 43;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(48, 66);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(56, 16);
            this.lblLegajo.TabIndex = 44;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblApynom
            // 
            this.lblApynom.AutoSize = true;
            this.lblApynom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApynom.Location = new System.Drawing.Point(234, 66);
            this.lblApynom.Name = "lblApynom";
            this.lblApynom.Size = new System.Drawing.Size(137, 16);
            this.lblApynom.TabIndex = 45;
            this.lblApynom.Text = "Nombre y Apellido";
            // 
            // txtClienteDni
            // 
            this.txtClienteDni.Location = new System.Drawing.Point(110, 27);
            this.txtClienteDni.Name = "txtClienteDni";
            this.txtClienteDni.ReadOnly = true;
            this.txtClienteDni.Size = new System.Drawing.Size(106, 20);
            this.txtClienteDni.TabIndex = 47;
            
            // 
            // lblClienteDniu
            // 
            this.lblClienteDniu.AutoSize = true;
            this.lblClienteDniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteDniu.Location = new System.Drawing.Point(73, 31);
            this.lblClienteDniu.Name = "lblClienteDniu";
            this.lblClienteDniu.Size = new System.Drawing.Size(31, 16);
            this.lblClienteDniu.TabIndex = 50;
            this.lblClienteDniu.Text = "Dni";
            // 
            // lblClienteApynom
            // 
            this.lblClienteApynom.AutoSize = true;
            this.lblClienteApynom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteApynom.Location = new System.Drawing.Point(234, 29);
            this.lblClienteApynom.Name = "lblClienteApynom";
            this.lblClienteApynom.Size = new System.Drawing.Size(137, 16);
            this.lblClienteApynom.TabIndex = 52;
            this.lblClienteApynom.Text = "Nombre y Apellido";
            // 
            // txtClienteApyNom
            // 
            this.txtClienteApyNom.Enabled = false;
            this.txtClienteApyNom.Location = new System.Drawing.Point(377, 27);
            this.txtClienteApyNom.Name = "txtClienteApyNom";
            this.txtClienteApyNom.Size = new System.Drawing.Size(318, 20);
            this.txtClienteApyNom.TabIndex = 51;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(709, 26);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarCliente.TabIndex = 53;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Location = new System.Drawing.Point(76, 53);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(706, 5);
            this.toolStrip2.TabIndex = 54;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(720, 129);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(63, 20);
            this.btnBuscarArticulo.TabIndex = 55;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click_1);
            // 
            // FormularioComprobanteMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblClienteApynom);
            this.Controls.Add(this.txtClienteApyNom);
            this.Controls.Add(this.lblClienteDniu);
            this.Controls.Add(this.txtClienteDni);
            this.Controls.Add(this.lblApynom);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCerrarMesa);
            this.Controls.Add(this.gbxFormaPago);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.nudTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.nudDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.nudSubTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudCantidadArticulo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.btnBuscarMozo);
            this.Controls.Add(this.txtApyNomMozo);
            this.Controls.Add(this.lblMozo);
            this.Controls.Add(this.txtMozoLegajo);
            this.Controls.Add(this.nudComensales);
            this.Controls.Add(this.lblComensales);
            this.Controls.Add(this.dgvGrilla);
            this.Name = "FormularioComprobanteMesa";
            this.Text = "Agregar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComensales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.gbxFormaPago.ResumeLayout(false);
            this.gbxFormaPago.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Label lblComensales;
        private System.Windows.Forms.NumericUpDown nudComensales;
        private System.Windows.Forms.TextBox txtMozoLegajo;
        private System.Windows.Forms.Label lblMozo;
        private System.Windows.Forms.TextBox txtApyNomMozo;
        private System.Windows.Forms.Button btnBuscarMozo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.NumericUpDown nudCantidadArticulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox gbxFormaPago;
        private System.Windows.Forms.RadioButton rdbCheque;
        private System.Windows.Forms.RadioButton rdbCtaCte;
        private System.Windows.Forms.RadioButton rdbTarjeta;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.Button btnCerrarMesa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarCantidadToolStripMenuItem;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblApynom;
        private System.Windows.Forms.TextBox txtClienteDni;
        private System.Windows.Forms.Label lblClienteDniu;
        private System.Windows.Forms.Label lblClienteApynom;
        private System.Windows.Forms.TextBox txtClienteApyNom;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Button btnBuscarArticulo;
    }
}