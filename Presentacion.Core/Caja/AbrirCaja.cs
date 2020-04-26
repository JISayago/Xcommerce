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
    public partial class AbrirCaja : Form
    {
        private readonly ICajaServicio _cajaServicio;
        public AbrirCaja()
        {
            InitializeComponent();

            _cajaServicio = new CajaServicio();

            nombreUsuarioLbl.Text = DatosSistema.NombreUsuario;
            
        }


    }
}
