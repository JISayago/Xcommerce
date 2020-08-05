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
using XCommerce.Servicios.Core.Salon.Mesa;

namespace Presentacion.Core.Caja
{
    public partial class FormularioCerrarCaja : Form
    {
        private readonly ICajaServicio _cajaServicio;
        private readonly IMesaServicio _mesaServicio;
        public FormularioCerrarCaja()
        {
            InitializeComponent();

            _cajaServicio = new CajaServicio();
            _mesaServicio = new MesaServicio();

            nombreUsuarioLbl.Text = DatosSistema.NombreUsuario;


        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (DatosSistema.UsuarioId == 0) throw new Exception("La caja no se puede cerrar como admin!");
            if (_mesaServicio.HayMesasAbiertas())
            {
                MessageBox.Show("Todavía hay mesas abiertas, no se puede cerar la caja hasta que no cierre las mesas");
                return;
            }

            var caja = _cajaServicio.Obtener(DatosSistema.CajaId);
            caja.UsuarioCierreId = DatosSistema.UsuarioId;
            caja.MontoCierre = nudMonto.Value;
            caja.MontoSistema = _cajaServicio.ObtenerMontoSistema(DatosSistema.CajaId);
            _cajaServicio.Cerrar(caja);

            DatosSistema.EstaCajaAbierta = false;
            this.Close();
        }
    }
}
