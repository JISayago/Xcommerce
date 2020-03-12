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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.lblComensales = new System.Windows.Forms.Label();
            this.nudComensales = new System.Windows.Forms.NumericUpDown();
            this.txtMozoLegajo = new System.Windows.Forms.TextBox();
            this.lblMozo = new System.Windows.Forms.Label();
            this.txtApyNomMozo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComensales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(3, 144);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(781, 302);
            this.dgvGrilla.TabIndex = 2;
            // 
            // lblComensales
            // 
            this.lblComensales.AutoSize = true;
            this.lblComensales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComensales.Location = new System.Drawing.Point(2, 12);
            this.lblComensales.Name = "lblComensales";
            this.lblComensales.Size = new System.Drawing.Size(107, 20);
            this.lblComensales.TabIndex = 3;
            this.lblComensales.Text = "Comensales";
            // 
            // nudComensales
            // 
            this.nudComensales.Location = new System.Drawing.Point(115, 12);
            this.nudComensales.Name = "nudComensales";
            this.nudComensales.Size = new System.Drawing.Size(106, 20);
            this.nudComensales.TabIndex = 4;
            // 
            // txtMozoLegajo
            // 
            this.txtMozoLegajo.Location = new System.Drawing.Point(115, 44);
            this.txtMozoLegajo.Name = "txtMozoLegajo";
            this.txtMozoLegajo.Size = new System.Drawing.Size(106, 20);
            this.txtMozoLegajo.TabIndex = 5;
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMozo.Location = new System.Drawing.Point(57, 42);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(52, 20);
            this.lblMozo.TabIndex = 6;
            this.lblMozo.Text = "Mozo";
            // 
            // txtApyNomMozo
            // 
            this.txtApyNomMozo.Location = new System.Drawing.Point(260, 44);
            this.txtApyNomMozo.Name = "txtApyNomMozo";
            this.txtApyNomMozo.Size = new System.Drawing.Size(405, 20);
            this.txtApyNomMozo.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(697, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 20);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo Barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(3, 116);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoBarras.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(157, 91);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 20);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(160, 116);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(246, 20);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(427, 91);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(127, 20);
            this.lblPrecioUnitario.TabIndex = 14;
            this.lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(430, 116);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(124, 20);
            this.txtPrecioUnitario.TabIndex = 13;
            // 
            // nudCantidadArticulo
            // 
            this.nudCantidadArticulo.Location = new System.Drawing.Point(594, 117);
            this.nudCantidadArticulo.Name = "nudCantidadArticulo";
            this.nudCantidadArticulo.Size = new System.Drawing.Size(71, 20);
            this.nudCantidadArticulo.TabIndex = 16;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(591, 92);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(697, 118);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 20);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // nudSubTotal
            // 
            this.nudSubTotal.Location = new System.Drawing.Point(705, 462);
            this.nudSubTotal.Name = "nudSubTotal";
            this.nudSubTotal.Size = new System.Drawing.Size(70, 20);
            this.nudSubTotal.TabIndex = 19;
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
            this.nudTotal.Location = new System.Drawing.Point(705, 534);
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(70, 20);
            this.nudTotal.TabIndex = 23;
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
            this.toolStrip1.Location = new System.Drawing.Point(1, 69);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(781, 5);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormularioComprobanteMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.Controls.Add(this.btnBuscar);
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
        private System.Windows.Forms.Button btnBuscar;
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
    }
}