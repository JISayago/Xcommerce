namespace Presentacion.Login.Usuario
{
    partial class FormularioUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioUsuario));
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.BarraLateralBotones = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnBloquear = new System.Windows.Forms.ToolStripButton();
            this.btnDesbloquear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cbxEstaBloqueado = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.BarraLateralBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlSeparador.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pnlSeparador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSeparador.Location = new System.Drawing.Point(68, -11);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(6, 583);
            this.pnlSeparador.TabIndex = 131;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Location = new System.Drawing.Point(386, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 29);
            this.panel1.TabIndex = 128;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(64, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(226, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(3, 8);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 13);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(296, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 21);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrilla.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(87, 38);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(691, 509);
            this.dgvGrilla.TabIndex = 130;
            this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
            // 
            // BarraLateralBotones
            // 
            this.BarraLateralBotones.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BarraLateralBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraLateralBotones.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.BarraLateralBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnBloquear,
            this.btnDesbloquear,
            this.toolStripSeparator1,
            this.btnActualizar,
            this.btnSalir,
            this.toolStripSeparator2,
            this.toolStripSeparator3});
            this.BarraLateralBotones.Location = new System.Drawing.Point(0, 0);
            this.BarraLateralBotones.Name = "BarraLateralBotones";
            this.BarraLateralBotones.Size = new System.Drawing.Size(78, 561);
            this.BarraLateralBotones.TabIndex = 129;
            this.BarraLateralBotones.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 51);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBloquear
            // 
            this.btnBloquear.Image = ((System.Drawing.Image)(resources.GetObject("btnBloquear.Image")));
            this.btnBloquear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(75, 51);
            this.btnBloquear.Text = "Bloquear";
            this.btnBloquear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Image = ((System.Drawing.Image)(resources.GetObject("btnDesbloquear.Image")));
            this.btnDesbloquear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(75, 51);
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(75, 6);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 51);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 51);
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(75, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(75, 6);
            // 
            // cbxEstaBloqueado
            // 
            this.cbxEstaBloqueado.AutoSize = true;
            this.cbxEstaBloqueado.Location = new System.Drawing.Point(90, 10);
            this.cbxEstaBloqueado.Name = "cbxEstaBloqueado";
            this.cbxEstaBloqueado.Size = new System.Drawing.Size(161, 17);
            this.cbxEstaBloqueado.TabIndex = 132;
            this.cbxEstaBloqueado.Text = "Mostrar usuarios bloqueados";
            this.cbxEstaBloqueado.ThreeState = true;
            this.cbxEstaBloqueado.UseVisualStyleBackColor = true;
            // 
            // FormularioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cbxEstaBloqueado);
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.BarraLateralBotones);
            this.Name = "FormularioUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormularioUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.BarraLateralBotones.ResumeLayout(false);
            this.BarraLateralBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.DataGridView dgvGrilla;
        public System.Windows.Forms.ToolStrip BarraLateralBotones;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnBloquear;
        private System.Windows.Forms.ToolStripButton btnDesbloquear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        protected System.Windows.Forms.CheckBox cbxEstaBloqueado;
    }
}