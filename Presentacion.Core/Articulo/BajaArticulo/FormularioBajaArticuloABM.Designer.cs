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
            this.btnNuevoMotivoBaja.Location = new System.Drawing.Point(407, 117);
            this.btnNuevoMotivoBaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoMotivoBaja.Name = "btnNuevoMotivoBaja";
            this.btnNuevoMotivoBaja.Size = new System.Drawing.Size(55, 24);
            this.btnNuevoMotivoBaja.TabIndex = 160;
            this.btnNuevoMotivoBaja.Text = "...";
            this.btnNuevoMotivoBaja.UseVisualStyleBackColor = true;
            this.btnNuevoMotivoBaja.Click += new System.EventHandler(this.btnNuevoMotivoBaja_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 161;
            this.label9.Text = "Motivo Baja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 162;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 163;
            this.label2.Text = "Observacion";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(556, 119);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(53, 22);
            this.nudCantidad.TabIndex = 164;
            // 
            // richBajaArticulo
            // 
            this.richBajaArticulo.Location = new System.Drawing.Point(109, 154);
            this.richBajaArticulo.Name = "richBajaArticulo";
            this.richBajaArticulo.Size = new System.Drawing.Size(500, 72);
            this.richBajaArticulo.TabIndex = 165;
            this.richBajaArticulo.Text = "";
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(110, 117);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(290, 24);
            this.cmbMotivo.TabIndex = 166;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(251, 70);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(147, 31);
            this.lblArticulo.TabIndex = 168;
            this.lblArticulo.Text = "No Articulo";
            // 
            // FormularioBajaArticuloABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 245);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.richBajaArticulo);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevoMotivoBaja);
            this.Controls.Add(this.label9);
            this.Name = "FormularioBajaArticuloABM";
            this.Text = "FormularioBajaArticuloABM";
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