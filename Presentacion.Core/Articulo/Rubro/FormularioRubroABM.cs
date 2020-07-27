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
using XCommerce.Servicios.Core.Articulo.Rubro;
using XCommerce.Servicios.Core.Articulo.Rubro.DTO;

namespace Presentacion.Core.Articulo.Rubro
{
    public partial class FormularioRubroABM : FormularioBaseABM
    {
        private readonly IRubroServicio _rubroServicio;


        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }

        public FormularioRubroABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _rubroServicio = new RubroServicio();

            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
            }
            AgregarControlesObligatorios(txtRubro, "Rubro");
        }

        public override void Inicializador(long? entidadId)
        {
            if (entidadId.HasValue) return;

            txtRubro.KeyPress += Validacion.NoSimbolos;
            txtRubro.KeyPress += Validacion.NoNumeros;
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

            var marca = _rubroServicio.ObtenerPorId(entidadId.Value);

            if (marca != null)
            {
                txtRubro.Text = marca.Descripcion;
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
            var rubroNuevo = new RubroDTO
            {
                Descripcion = txtRubro.Text,
                EstaEliminado = false

            };
            _rubroServicio.Insertar(rubroNuevo);
            return true;

        }

        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            _rubroServicio.Eliminar(EntidadId.Value);

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
            var rubroModificar = new RubroDTO
            {
                Id = EntidadId.Value,
                Descripcion = txtRubro.Text,
            };
            _rubroServicio.Modificar(rubroModificar);

            return true;

        }
    }
}
