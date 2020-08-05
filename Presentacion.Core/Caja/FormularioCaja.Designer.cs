namespace Presentacion.Core.Caja
{
    partial class FormularioCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCaja));
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCaja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMontoSistema = new System.Windows.Forms.Label();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnComprobantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnAbrir.Location = new System.Drawing.Point(53, 240);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(242, 33);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(301, 240);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(242, 33);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(84, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 140);
            this.panel1.TabIndex = 2;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblCaja.Location = new System.Drawing.Point(248, 18);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(91, 32);
            this.lblCaja.TabIndex = 3;
            this.lblCaja.Text = "CAJA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label1.Location = new System.Drawing.Point(173, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Montos Sistema:";
            // 
            // lblMontoSistema
            // 
            this.lblMontoSistema.AutoSize = true;
            this.lblMontoSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.lblMontoSistema.Location = new System.Drawing.Point(310, 362);
            this.lblMontoSistema.Name = "lblMontoSistema";
            this.lblMontoSistema.Size = new System.Drawing.Size(16, 18);
            this.lblMontoSistema.TabIndex = 5;
            this.lblMontoSistema.Text = "0";
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnMovimientos.Location = new System.Drawing.Point(53, 292);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(119, 33);
            this.btnMovimientos.TabIndex = 6;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.UseVisualStyleBackColor = false;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDetalles.Location = new System.Drawing.Point(178, 292);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(117, 33);
            this.btnDetalles.TabIndex = 7;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnVentas.Location = new System.Drawing.Point(424, 292);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(119, 33);
            this.btnVentas.TabIndex = 9;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnComprobantes
            // 
            this.btnComprobantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnComprobantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnComprobantes.Location = new System.Drawing.Point(301, 292);
            this.btnComprobantes.Name = "btnComprobantes";
            this.btnComprobantes.Size = new System.Drawing.Size(117, 33);
            this.btnComprobantes.TabIndex = 8;
            this.btnComprobantes.Text = "Arqueos";
            this.btnComprobantes.UseVisualStyleBackColor = false;
            this.btnComprobantes.Click += new System.EventHandler(this.btnComprobantes_Click);
            // 
            // FormularioCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 422);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnComprobantes);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnMovimientos);
            this.Controls.Add(this.lblMontoSistema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAbrir);
            this.Name = "FormularioCaja";
            this.Text = "Caja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMontoSistema;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnComprobantes;
    }
}