namespace Presentacion.Core.Salon.Mesa.Control
{
    partial class CtrolMesa
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.MenuControlMesa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAbrirMesa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarMesa = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.MenuControlMesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.ContextMenuStrip = this.MenuControlMesa;
            this.lblNumeroMesa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNumeroMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMesa.Location = new System.Drawing.Point(0, 0);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(100, 67);
            this.lblNumeroMesa.TabIndex = 0;
            this.lblNumeroMesa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNumeroMesa.DoubleClick += new System.EventHandler(this.lblNumeroMesa_DoubleClick);
            // 
            // MenuControlMesa
            // 
            this.MenuControlMesa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbrirMesa,
            this.menuCerrarMesa});
            this.MenuControlMesa.Name = "MenuControlMesa";
            this.MenuControlMesa.Size = new System.Drawing.Size(181, 70);
            // 
            // menuAbrirMesa
            // 
            this.menuAbrirMesa.Name = "menuAbrirMesa";
            this.menuAbrirMesa.Size = new System.Drawing.Size(180, 22);
            this.menuAbrirMesa.Text = "Abrir Mesa";
            this.menuAbrirMesa.Click += new System.EventHandler(this.menuAbrirMesa_Click);
            // 
            // menuCerrarMesa
            // 
            this.menuCerrarMesa.Name = "menuCerrarMesa";
            this.menuCerrarMesa.Size = new System.Drawing.Size(180, 22);
            this.menuCerrarMesa.Text = "Cerrar Mesa";
            this.menuCerrarMesa.Click += new System.EventHandler(this.menuCerrarMesa_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.ContextMenuStrip = this.MenuControlMesa;
            this.lblPrecio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(0, 67);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 33);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CtrolMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNumeroMesa);
            this.Name = "CtrolMesa";
            this.Size = new System.Drawing.Size(100, 100);
            this.MenuControlMesa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblNumeroMesa;
        public System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ContextMenuStrip MenuControlMesa;
        private System.Windows.Forms.ToolStripMenuItem menuAbrirMesa;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarMesa;
    }
}
