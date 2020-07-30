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
using XCommerce.Servicios.Core.CondicionIva;
using XCommerce.Servicios.Core.CondicionIva.DTO;

namespace Presentacion.Core.CondicionIva
{
    public partial class FormularioCondicionIvaABM : FormularioBaseABM
    {

        private readonly ICondicionIvaServicio _condicionIvaServicio;

        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }

        public FormularioCondicionIvaABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();
            _condicionIvaServicio = new CondicionIvaServicio();

            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
            }

            AgregarControlesObligatorios(txtCondicionIva, "CondicionIva");
        }

        public override void Inicializador(long? entidadId)
        {
            if (entidadId.HasValue) return;

            txtCondicionIva.KeyPress += Validacion.NoSimbolos;
            txtCondicionIva.KeyPress += Validacion.NoNumeros;
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

            var condicionIva = _condicionIvaServicio.ObtenerPorId(entidadId.Value);

            if (condicionIva != null)
            {
                txtCondicionIva.Text = condicionIva.Descripcion;
            }
            else
            {
                MessageBox.Show(@"Ocurrio un Error Grave", @"Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        public override bool EjecutarComandoNuevo()
        {
            if (!VerificarDatosObligatorios())
            {
                MessageBox.Show(@"Por favor ingrese los campos Obligatorios.", @"Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            var condicionIvaNuevo = new CondicionIvaDTO
            {
                Descripcion = txtCondicionIva.Text

            };
            _condicionIvaServicio.Insertar(condicionIvaNuevo);
            return true;

        }

        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            _condicionIvaServicio.Eliminar(EntidadId.Value);

            return true;

        }

        public override bool EjecutarComandoModificar()
        {
            if (!VerificarDatosObligatorios())
            {
                MessageBox.Show(@"Por favor ingrese los campos Obligatorios.", @"Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            var condicionIvaModificar = new CondicionIvaDTO
            {
                Id = EntidadId.Value,
                Descripcion = txtCondicionIva.Text,
            };
            _condicionIvaServicio.Modificar(condicionIvaModificar);

            return true;

        }
    }
}
