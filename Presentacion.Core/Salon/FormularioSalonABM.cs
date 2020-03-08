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
using XCommerce.Servicios.Core.Salon;
using XCommerce.Servicios.Core.Salon.DTO;

namespace Presentacion.Core.Salon
{
    public partial class FormularioSalonABM : FormularioBaseABM
    {
        private readonly ISalonServicio _salonServicio;


        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }
        public FormularioSalonABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _salonServicio = new SalonServicio();

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

            txtSalon.KeyPress += Validacion.NoSimbolos;
            txtSalon.KeyPress += Validacion.NoNumeros;
        }

        public override void DesactivarControles(object obj)
        {
            base.DesactivarControles(obj);

            btnLimpiar.Enabled = false;
            btnLimpiar.Visible = false;
        }

        public override void CargarDatos(long? entidadId)
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

            var salon = _salonServicio.ObtenerPorId(entidadId.Value);

            if (salon != null)
            {
                txtSalon.Text = salon.Descripcion;
            }
            else
            {
                MessageBox.Show(@"Ocurrio un Error Grave", @"Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        public override bool EjecutarComandoNuevo()
        {
            var salonNuevo = new SalonDTO
            {
                Descripcion = txtSalon.Text,
                EstaEliminado = false

            };
            _salonServicio.Insertar(salonNuevo);
            return true;

        }
        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            _salonServicio.Eliminar(EntidadId.Value);

            return true;

        }
        public override bool EjecutarComandoModificar()
        {
            var salonModificar = new SalonDTO
            {
                Id = EntidadId.Value,
                Descripcion = txtSalon.Text,
            };
            _salonServicio.Modificar(salonModificar);

            return true;

        }
    }
}

