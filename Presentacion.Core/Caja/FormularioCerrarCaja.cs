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
    public partial class FormularioCerrarCaja : Form
    {
        private readonly ICajaServicio _cajaServicio;
        public FormularioCerrarCaja()
        {
            InitializeComponent();

            _cajaServicio = new CajaServicio();

            nombreUsuarioLbl.Text = DatosSistema.NombreUsuario;
        }

        //TODO IMPORTANTE
        //que hacer cuando el programa se cierra y no se cerro la caja
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (DatosSistema.UsuarioId == 0) throw new Exception("La caja no se puede cerrar como admin!");

            var caja = _cajaServicio.Obtener(DatosSistema.CajaId);
            caja.UsuarioCierreId = DatosSistema.UsuarioId;
            caja.MontoCierre = nudMonto.Value;
            _cajaServicio.Cerrar(caja);

            DatosSistema.EstaCajaAbierta = false;
            this.Close();
        }
    }
}
