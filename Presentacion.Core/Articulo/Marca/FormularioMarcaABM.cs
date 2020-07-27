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
using XCommerce.Servicios.Core.Articulo.Marca;
using XCommerce.Servicios.Core.Articulo.Marca.DTO;

namespace Presentacion.Core.Articulo.Marca
{
    public partial class FormularioMarcaABM : FormularioBaseABM
    {
        private readonly IMarcaServicio _marcaServicio;


        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }

        public FormularioMarcaABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _marcaServicio = new MarcaServicio();

            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
            }

            AgregarControlesObligatorios(txtMarca, "Marca");
        }

        public override void Inicializador(long? entidadId)
        {
            if (entidadId.HasValue) return;

            txtMarca.KeyPress += Validacion.NoSimbolos;
            txtMarca.KeyPress += Validacion.NoNumeros;
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

            var marca = _marcaServicio.ObtenerPorId(entidadId.Value);

            if (marca != null)
            {
                txtMarca.Text = marca.Descripcion;
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
            var marcaNueva = new MarcaDTO
            {
                Descripcion = txtMarca.Text,
                EstaEliminado = false

            };
            _marcaServicio.Insertar(marcaNueva);
            return true;

        }

        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            _marcaServicio.Eliminar(EntidadId.Value);

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
            var marcaModificar = new MarcaDTO
            {
                Id = EntidadId.Value,
                Descripcion = txtMarca.Text,
            };
            _marcaServicio.Modificar(marcaModificar);

            return true;

        }
    }
}
