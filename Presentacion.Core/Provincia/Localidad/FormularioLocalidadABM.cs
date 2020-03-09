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
using XCommerce.Servicios.Core.Localidad;
using XCommerce.Servicios.Core.Localidad.DTO;
using XCommerce.Servicios.Core.Provincia;
using XCommerce.Servicios.Core.Provincia.DTO;

namespace Presentacion.Core.Provincia.Localidad
{
    public partial class FormularioLocalidadABM : FormularioBaseABM
    {
        private readonly IProvinciaServicio _provinciaServicio;
        private readonly ILocalidadServicio _localidadServicio;

        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }
        public FormularioLocalidadABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _provinciaServicio = new ProvinciaServicio();
            _localidadServicio = new LocalidadServicio();

            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);
                cmbProvincia.Enabled = false;
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
                
            }

        }

        public override void Inicializador(long? entidadId)
        {
            if (entidadId.HasValue) return;

            CargarComboBox(cmbProvincia, _provinciaServicio.ObtenerProvincia(string.Empty), "Descripcion", "Id");
           
        

            txtLocalidad.KeyPress += Validacion.NoSimbolos;
            txtLocalidad.KeyPress += Validacion.NoNumeros;
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

            var localidad = _localidadServicio.ObtenerPorId(entidadId.Value);

            if (localidad != null)
            {
                CargarComboBox(cmbProvincia, _provinciaServicio.ObtenerProvincia(localidad.ProvinciaDescrip), "Descripcion", "Id");
                txtLocalidad.Text = localidad.Descripcion;

            }
            else
            {
                MessageBox.Show(@"Ocurrio un Error Grave", @"Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        public override bool EjecutarComandoNuevo()
        {
            var localidadNueva = new LocalidadDTO
            {
                ProvinciaId = (long)cmbProvincia.SelectedValue,
                Descripcion = txtLocalidad.Text,
                EstaEliminado = false

            };
            _localidadServicio.Insertar(localidadNueva);
            return true;

        }

        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            _localidadServicio.Eliminar(EntidadId.Value);

            return true;

        }

        public override bool EjecutarComandoModificar()
        {
            var localidadModificar = new LocalidadDTO
            {
                Id = EntidadId.Value,
                Descripcion = txtLocalidad.Text,
            };
            _localidadServicio.Modificar(localidadModificar);

            return true;

        }

        private void btnNuevaProvincia_Click(object sender, EventArgs e)
        {
            var FormularioABMProvincia = new FormularioProvinciaABM(TipoOperacion.Nuevo);
            FormularioABMProvincia.ShowDialog();
            
        }
    }
}
