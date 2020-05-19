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
using XCommerce.Servicios.Core.Caja.DTO;

namespace Presentacion.Core.Caja
{
    public partial class FormularioAbrirCaja : Form
    {
        private readonly ICajaServicio _cajaServicio;
        public FormularioAbrirCaja()
        {
            InitializeComponent();

            _cajaServicio = new CajaServicio();

            nombreUsuarioLbl.Text = DatosSistema.NombreUsuario;
            
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (DatosSistema.UsuarioId == 0) throw new Exception("La caja no se puede abrir como admin!");
            var caja = new CajaDTO
            {
                MontoApertura = nudMontoApertura.Value,
                UsuarioAperturaId = DatosSistema.UsuarioId, //DatosSistema.UsuarioID,
                MontoCierre = 0,
                UsuarioCierreId = 0
            };

            DatosSistema.CajaId = _cajaServicio.Abrir(caja);
            DatosSistema.EstaCajaAbierta = true;
            
            //detallecomprobante?

            this.Close();
        }
    }
}
