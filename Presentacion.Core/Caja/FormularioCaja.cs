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

namespace Presentacion.Core.Caja
{
    public partial class FormularioCaja : Form
    {
        public FormularioCaja()
        {
            InitializeComponent();
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
