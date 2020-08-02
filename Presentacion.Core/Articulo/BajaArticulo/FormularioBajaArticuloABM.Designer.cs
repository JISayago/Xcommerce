namespace Presentacion.Core.Articulo.BajaArticulo
{
    partial class FormularioBajaArticuloABM
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
            this.btnNuevoMotivoBaja = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.richBajaArticulo = new System.Windows.Forms.RichTextBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoMotivoBaja
            // 
            this.btnNuevoMotivoBaja.Location = new System.Drawing.Point(265, 95);
            this.btnNuevoMotivoBaja.Name = "btnNuevoMotivoBaja";
            this.btnNuevoMotivoBaja.Size = new System.Drawing.Size(41, 21);
            this.btnNuevoMotivoBaja.TabIndex = 1;
            this.btnNuevoMotivoBaja.Text = "...";
            this.btnNuevoMotivoBaja.UseVisualStyleBackColor = true;
            this.btnNuevoMotivoBaja.Click += new System.EventHandler(this.btnNuevoMotivoBaja_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 161;
            this.label9.Text = "Motivo Baja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 162;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 163;
            this.label2.Text = "Observacion";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(373, 96);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(40, 20);
            this.nudCantidad.TabIndex = 2;
            // 
            // richBajaArticulo
            // 
            this.richBajaArticulo.Location = new System.Drawing.Point(82, 125);
            this.richBajaArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richBajaArticulo.Name = "richBajaArticulo";
            this.richBajaArticulo.Size = new System.Drawing.Size(331, 59);
            this.richBajaArticulo.TabIndex = 3;
            this.richBajaArticulo.Text = "";
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(82, 95);
            this.cmbMotivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(178, 21);
            this.cmbMotivo.TabIndex = 0;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(9, 58);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(117, 25);
            this.lblArticulo.TabIndex = 168;
            this.lblArticulo.Text = "No Articulo";
            // 
            // FormularioBajaArticuloABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 199);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.richBajaArticulo);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevoMotivoBaja);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(604, 495);
            this.Name = "FormularioBajaArticuloABM";
            this.Text = "FormularioBajaArticuloABM";
            this.Activated += new System.EventHandler(this.FormularioBajaArticuloABM_Activated);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.btnNuevoMotivoBaja, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.nudCantidad, 0);
            this.Controls.SetChildIndex(this.richBajaArticulo, 0);
            this.Controls.SetChildIndex(this.cmbMotivo, 0);
            this.Controls.SetChildIndex(this.lblArticulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoMotivoBaja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.RichTextBox richBajaArticulo;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label lblArticulo;
    }
}