namespace Presentacion.Core.Reserva
{
    partial class FormularioReservaABM
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
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.cmbMesa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.lblUsuarioRegistra = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApynomb = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApyNomb = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.txtClienteDni = new System.Windows.Forms.TextBox();
            this.lblDniBuscar = new System.Windows.Forms.Label();
            this.lblSalon = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblFechaDeReserva = new System.Windows.Forms.Label();
            this.nudSenia = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblSenia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSenia)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSalon
            // 
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(55, 67);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(158, 21);
            this.cmbSalon.TabIndex = 56;
            // 
            // cmbMesa
            // 
            this.cmbMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesa.FormattingEnabled = true;
            this.cmbMesa.Location = new System.Drawing.Point(55, 94);
            this.cmbMesa.Name = "cmbMesa";
            this.cmbMesa.Size = new System.Drawing.Size(158, 21);
            this.cmbMesa.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Horario de Reserva";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(123, 161);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(90, 20);
            this.dtpHora.TabIndex = 53;
            // 
            // lblUsuarioRegistra
            // 
            this.lblUsuarioRegistra.AutoSize = true;
            this.lblUsuarioRegistra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioRegistra.Location = new System.Drawing.Point(101, 219);
            this.lblUsuarioRegistra.Name = "lblUsuarioRegistra";
            this.lblUsuarioRegistra.Size = new System.Drawing.Size(177, 13);
            this.lblUsuarioRegistra.TabIndex = 52;
            this.lblUsuarioRegistra.Text = "Usuario Registrando Reserva:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(329, 193);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(169, 20);
            this.txtCelular.TabIndex = 51;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(329, 165);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(169, 20);
            this.txtDNI.TabIndex = 50;
            // 
            // txtApynomb
            // 
            this.txtApynomb.Location = new System.Drawing.Point(329, 133);
            this.txtApynomb.Name = "txtApynomb";
            this.txtApynomb.ReadOnly = true;
            this.txtApynomb.Size = new System.Drawing.Size(169, 20);
            this.txtApynomb.TabIndex = 49;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(281, 196);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 48;
            this.lblCelular.Text = "Celular";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(297, 168);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 47;
            this.lblDNI.Text = "DNI";
            // 
            // lblApyNomb
            // 
            this.lblApyNomb.AutoSize = true;
            this.lblApyNomb.Location = new System.Drawing.Point(231, 136);
            this.lblApyNomb.Name = "lblApyNomb";
            this.lblApyNomb.Size = new System.Drawing.Size(92, 13);
            this.lblApyNomb.TabIndex = 46;
            this.lblApyNomb.Text = "Nombre y Apellido";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(262, 63);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(174, 20);
            this.btnNuevoCliente.TabIndex = 45;
            this.btnNuevoCliente.Text = "Agregar Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click_1);
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.Location = new System.Drawing.Point(445, 98);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(53, 20);
            this.btnBuscarDni.TabIndex = 44;
            this.btnBuscarDni.Text = "buscar";
            this.btnBuscarDni.UseVisualStyleBackColor = true;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click_1);
            // 
            // txtClienteDni
            // 
            this.txtClienteDni.Location = new System.Drawing.Point(329, 99);
            this.txtClienteDni.Name = "txtClienteDni";
            this.txtClienteDni.Size = new System.Drawing.Size(107, 20);
            this.txtClienteDni.TabIndex = 43;
            // 
            // lblDniBuscar
            // 
            this.lblDniBuscar.AutoSize = true;
            this.lblDniBuscar.Location = new System.Drawing.Point(244, 102);
            this.lblDniBuscar.Name = "lblDniBuscar";
            this.lblDniBuscar.Size = new System.Drawing.Size(76, 13);
            this.lblDniBuscar.TabIndex = 42;
            this.lblDniBuscar.Text = "DNI de Cliente";
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Location = new System.Drawing.Point(12, 70);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(34, 13);
            this.lblSalon.TabIndex = 41;
            this.lblSalon.Text = "Salon";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(11, 102);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(33, 13);
            this.lblMesa.TabIndex = 40;
            this.lblMesa.Text = "Mesa";
            // 
            // lblFechaDeReserva
            // 
            this.lblFechaDeReserva.AutoSize = true;
            this.lblFechaDeReserva.Location = new System.Drawing.Point(16, 135);
            this.lblFechaDeReserva.Name = "lblFechaDeReserva";
            this.lblFechaDeReserva.Size = new System.Drawing.Size(95, 13);
            this.lblFechaDeReserva.TabIndex = 39;
            this.lblFechaDeReserva.Text = "Fecha de Reserva";
            // 
            // nudSenia
            // 
            this.nudSenia.Location = new System.Drawing.Point(123, 189);
            this.nudSenia.Name = "nudSenia";
            this.nudSenia.Size = new System.Drawing.Size(90, 20);
            this.nudSenia.TabIndex = 38;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(123, 129);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(90, 20);
            this.dtpFecha.TabIndex = 37;
            // 
            // lblSenia
            // 
            this.lblSenia.AutoSize = true;
            this.lblSenia.Location = new System.Drawing.Point(74, 196);
            this.lblSenia.Name = "lblSenia";
            this.lblSenia.Size = new System.Drawing.Size(32, 13);
            this.lblSenia.TabIndex = 36;
            this.lblSenia.Text = "Seña";
            // 
            // FormularioReservaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 238);
            this.Controls.Add(this.cmbSalon);
            this.Controls.Add(this.cmbMesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.lblUsuarioRegistra);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApynomb);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApyNomb);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnBuscarDni);
            this.Controls.Add(this.txtClienteDni);
            this.Controls.Add(this.lblDniBuscar);
            this.Controls.Add(this.lblSalon);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.lblFechaDeReserva);
            this.Controls.Add(this.nudSenia);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblSenia);
            this.MaximumSize = new System.Drawing.Size(527, 277);
            this.MinimumSize = new System.Drawing.Size(527, 277);
            this.Name = "FormularioReservaABM";
            this.Text = "FormularioReservaABM";
            //this.Activated += new System.EventHandler(this.FormularioReservaABM_Activated);
            this.Controls.SetChildIndex(this.lblSenia, 0);
            this.Controls.SetChildIndex(this.dtpFecha, 0);
            this.Controls.SetChildIndex(this.nudSenia, 0);
            this.Controls.SetChildIndex(this.lblFechaDeReserva, 0);
            this.Controls.SetChildIndex(this.lblMesa, 0);
            this.Controls.SetChildIndex(this.lblSalon, 0);
            this.Controls.SetChildIndex(this.lblDniBuscar, 0);
            this.Controls.SetChildIndex(this.txtClienteDni, 0);
            this.Controls.SetChildIndex(this.btnBuscarDni, 0);
            this.Controls.SetChildIndex(this.btnNuevoCliente, 0);
            this.Controls.SetChildIndex(this.lblApyNomb, 0);
            this.Controls.SetChildIndex(this.lblDNI, 0);
            this.Controls.SetChildIndex(this.lblCelular, 0);
            this.Controls.SetChildIndex(this.txtApynomb, 0);
            this.Controls.SetChildIndex(this.txtDNI, 0);
            this.Controls.SetChildIndex(this.txtCelular, 0);
            this.Controls.SetChildIndex(this.lblUsuarioRegistra, 0);
            this.Controls.SetChildIndex(this.dtpHora, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbMesa, 0);
            this.Controls.SetChildIndex(this.cmbSalon, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudSenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.ComboBox cmbMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblUsuarioRegistra;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApynomb;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApyNomb;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.TextBox txtClienteDni;
        private System.Windows.Forms.Label lblDniBuscar;
        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblFechaDeReserva;
        private System.Windows.Forms.NumericUpDown nudSenia;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblSenia;
    }
}