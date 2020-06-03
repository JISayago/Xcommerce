using Presentacion.FormulariosBase;
using Presentacion.FormulariosBase.Helpers;
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
using XCommerce.Servicios.Core.Articulo.BajaArticulo.MotivoBaja;
using XCommerce.Servicios.Core.Articulo.BajaArticulo.MotivoBaja.DTO;

namespace Presentacion.Core.Articulo.MotivoBaja
{
    public partial class FormularioMotivoBajaABM : FormularioBaseABM
    {
        private readonly IMotivoBajaServicio _motivoBajaServicio;


        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }

        public FormularioMotivoBajaABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _motivoBajaServicio = new MotivoBajaServicio();

            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
            }

        }

        public override void Inicializador(long? entidadId)
        {
            if (entidadId.HasValue) return;

            txtMotivoBaja.KeyPress += Validacion.NoSimbolos;
            txtMotivoBaja.KeyPress += Validacion.NoNumeros;
        }

        public override void DesactivarControles(object obj)
        {
            base.DesactivarControles(obj);

            btnLimpiar.Enabled = false;
            btnLimpiar.Visible = false;
        }

        /*public override void CargarDatos(long? entidadId)
        {
            if (!entidadId.HasValue)
            {
                MessageBox.Show(@"Ocurrio un Error Grave", @"Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                this.Close();
            }

            if (TipoOperacion == TipoOperacion.Eliminar)
            {
                btnLimpiar.Enabled = false;
            }

            var provincia = _motivoBajaServicio.ObtenerPorId(entidadId.Value);

        }*/

        public override bool EjecutarComandoNuevo()
        {
            var motivoBajaNuevo = new MotivoBajaDTO
            {
                Descripcion = txtMotivoBaja.Text,

            };

            _motivoBajaServicio.Insertar(motivoBajaNuevo);
            return true;

        }
    }
}
