using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.FormaPago;

namespace Presentacion.Core.FormaPago
{
    public partial class FormularioFormaPago : Form
    {
        private readonly IFormaPagoServicio _formaPagoServicio;
        public FormularioFormaPago()
        {
            InitializeComponent();
            _formaPagoServicio = new FormaPagoServicio();

            dgvGrilla.DataSource = _formaPagoServicio.Obtener(TipoFormaPago.Efectivo);
            //resetear_grilla();
        }

        private void resetear_grilla()
        {
            for (int i = 0; i < dgvGrilla.ColumnCount; i++)
            {
                dgvGrilla.Columns[i].Visible = false;
            }
            dgvGrilla.Columns["TipoFormaPago"].Visible = true;
            dgvGrilla.Columns["TipoFormaPago"].Width = 125;
            dgvGrilla.Columns["TipoFormaPago"].HeaderText = "FormaPago";
            
            dgvGrilla.Columns["ComprobanteId"].Visible = true;
            dgvGrilla.Columns["ComprobanteId"].Width = 50;
            dgvGrilla.Columns["ComprobanteId"].HeaderText = "ComproId";

            dgvGrilla.Columns["Monto"].Visible = true;
            dgvGrilla.Columns["Monto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Monto"].HeaderText = "Monto";

            if (rbCtaCte.Checked) {
                dgvGrilla.Columns["ClienteId"].Visible = true;
                dgvGrilla.Columns["ClienteId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["ClienteId"].HeaderText = "ClienteId";

            }
            if (rbTarjeta.Checked) {
                dgvGrilla.Columns["Cupon"].Visible = true;
                dgvGrilla.Columns["Cupon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Cupon"].HeaderText = "Monto";

                dgvGrilla.Columns["Numero"].Visible = true;
                dgvGrilla.Columns["Numero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Numero"].HeaderText = "Numero";

                dgvGrilla.Columns["NumeroTarjeta"].Visible = true;
                dgvGrilla.Columns["NumeroTarjeta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["NumeroTarjeta"].HeaderText = "Numero Tarjeta";


                dgvGrilla.Columns["PlanTarjetaId"].Visible = true;
                dgvGrilla.Columns["PlanTarjetaId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["PlanTarjetaId"].HeaderText = "Numero Tarjeta";
            }

            if (rbCheque.Checked) {

                dgvGrilla.Columns["BancoId"].Visible = true;
                dgvGrilla.Columns["BancoId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["BancoId"].HeaderText = "Monto";

                dgvGrilla.Columns["Numero"].Visible = true;
                dgvGrilla.Columns["Numero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Numero"].HeaderText = "Numero";

                dgvGrilla.Columns["EnteEmisor"].Visible = true;
                dgvGrilla.Columns["EnteEmisor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["EnteEmisor"].HeaderText = "EnteEmisor";


                dgvGrilla.Columns["FechaEmision"].Visible = true;
                dgvGrilla.Columns["FechaEmision"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["FechaEmision"].HeaderText = "Fecha Emsision";

                dgvGrilla.Columns["Dias"].Visible = true;
                dgvGrilla.Columns["Dias"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvGrilla.Columns["Dias"].HeaderText = "Dias";


            }

        }

        void filtrar(TipoFormaPago tipofp, TipoComprobante tipocomp)
        {
            var data = _formaPagoServicio.Obtener(TipoFormaPago.Efectivo);
            //data = data.Where(x => x.)
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _formaPagoServicio.Obtener(TipoFormaPago.Efectivo);
            //resetear_grilla();

        }

        private void rbCtaCte_CheckedChanged(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _formaPagoServicio.Obtener(TipoFormaPago.CuentaCorriente);
            //resetear_grilla();
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _formaPagoServicio.Obtener(TipoFormaPago.Tarjeta);
            //resetear_grilla();

        }

        private void rbCheque_CheckedChanged(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _formaPagoServicio.Obtener(TipoFormaPago.Cheque);
            //resetear_grilla();
        }
    }
}
