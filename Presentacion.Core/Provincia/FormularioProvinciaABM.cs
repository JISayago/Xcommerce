namespace Presentacion.Core.Provincia
{
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
    using XCommerce.Servicios.Core.Provincia;
    using XCommerce.Servicios.Core.Provincia.DTO;

    public partial class FormularioProvinciaABM : FormularioBaseABM
    {
        private readonly IProvinciaServicio _provinciaServicio;
        

        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }
        public FormularioProvinciaABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _provinciaServicio = new ProvinciaServicio();

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

            txtProvincia.KeyPress += Validacion.NoSimbolos;
            txtProvincia.KeyPress += Validacion.NoNumeros;
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

            var provincia = _provinciaServicio.ObtenerPorId(entidadId.Value);

            if(provincia != null)
            {
                txtProvincia.Text = provincia.Descripcion;
            }
            else
            {
                MessageBox.Show(@"Ocurrio un Error Grave", @"Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        public override bool EjecutarComandoNuevo()
        {
            var provinciaNueva = new ProvinciaDTO
            {
                Descripcion = txtProvincia.Text,
                EstaEliminado = false

            };
            _provinciaServicio.Insertar(provinciaNueva);
            return true;

        }
        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            _provinciaServicio.Eliminar(EntidadId.Value);

            return true;

        }
        public override bool EjecutarComandoModificar()
        {
            var provinciaModificar = new ProvinciaDTO
            {
                Id = EntidadId.Value,
                Descripcion = txtProvincia.Text,
            };
            _provinciaServicio.Modificar(provinciaModificar);

            return true;

        }
    }
}

