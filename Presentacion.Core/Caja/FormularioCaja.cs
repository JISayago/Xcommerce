using Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCommerce.Servicios.Core.Caja;

namespace Presentacion.Core.Caja
{
    public partial class FormularioCaja : Form
    {
        private readonly ICajaServicio _cajaServicio;
        public FormularioCaja()
        {
            InitializeComponent();
            _cajaServicio = new CajaServicio();
            if (DatosSistema.EstaCajaAbierta)
            {
                lblMontoSistema.Text = _cajaServicio.ObtenerMontoSistema(DatosSistema.CajaId).ToString();
            } else
            {
                lblMontoSistema.Text = "Caja Cerrada";
            }
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (!DatosSistema.EstaCajaAbierta)
            {
                FormularioAbrirCaja fAbrirCaja = new FormularioAbrirCaja();
                fAbrirCaja.ShowDialog();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (DatosSistema.EstaCajaAbierta)
            {
                FormularioCerrarCaja fCerrarCaja = new FormularioCerrarCaja();
                fCerrarCaja.ShowDialog();
            }
        }
    }
}
