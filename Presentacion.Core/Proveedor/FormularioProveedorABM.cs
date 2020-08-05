using Presentacion.Core.CondicionIva;
using Presentacion.FormulariosBase;
using Presentacion.FormulariosBase.Helpers;
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
using XCommerce.Servicios.Core.Proveedor;
using XCommerce.Servicios.Core.Proveedor.DTO;

namespace Presentacion.Core.Proveedor
{
    public partial class FormularioProveedorABM : FormularioBaseABM
    {
        private IProveedorServicio _proveedorServicio;
        private ICondicionIvaServicio _condicionIvaServicio;

        public FormularioProveedorABM()
        {
            InitializeComponent();
        }

        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }

        public FormularioProveedorABM(TipoOperacion tipoOperacion, long? entidadId = null)
           : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _proveedorServicio = new ProveedorServicio();
            _condicionIvaServicio = new CondicionIvaServicio();

            CargarComboBox(cmbCondicionIva, _condicionIvaServicio.ObtenerCondicionIva(string.Empty), "Descripcion", "Id");

            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
            }

            AgregarControlesObligatorios(txtContacto, "Contacto");
            AgregarControlesObligatorios(txtEmail, "Email");
            AgregarControlesObligatorios(txtRazonSocial, "RazonSocial");
            AgregarControlesObligatorios(txtTelefono, "Telefono");
            AgregarControlesObligatorios(cmbCondicionIva, "CondicionIva");
           
        }



        public override bool EjecutarComandoNuevo()
        {
            if (!VerificarDatosObligatorios())
            {
                MessageBox.Show(@"Por favor ingrese los campos Obligatorios.", @"Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            var ProveedorNuevo = new ProveedorDTO
            {
                RazonSocial = txtRazonSocial.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                CondicionIvaId = ((CondicionIvaDTO)cmbCondicionIva.SelectedItem).Id,
                Contacto = txtContacto.Text

            };
            _proveedorServicio.Insertar(ProveedorNuevo);
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
            var ProveedorModificar = new ProveedorDTO
            {
                RazonSocial = txtRazonSocial.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                CondicionIvaId = ((CondicionIvaDTO)cmbCondicionIva.SelectedItem).Id,
                Contacto = txtContacto.Text

            };
            _proveedorServicio.Modificar(ProveedorModificar);

            return true;

        }


        public override void CargarDatos(long? entidadId)
        {
            if (!entidadId.HasValue)
            {
                MessageBox.Show(@"Ocurrio un Error Grave", @"Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                this.Close();
            }

            /*if (TipoOperacion == TipoOperacion.Eliminar)
            {
                btnLimpiar.Enabled = false;
            }*/

            var proveedor = _proveedorServicio.ObtenerPorId(entidadId.Value);

            if (proveedor != null)
            {
                txtRazonSocial.Text = proveedor.RazonSocial;
                txtTelefono.Text = proveedor.Telefono;
                txtEmail.Text = proveedor.Email;
                txtContacto.Text = proveedor.Contacto;
                CargarComboBox(cmbCondicionIva, _condicionIvaServicio.ObtenerCondicionIva(string.Empty), "Descripcion", "Id");
            }
            else
            {
                MessageBox.Show(@"Ocurrio un Error Grave", @"Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnNuevaCondicionIva_Click(object sender, EventArgs e)
        {
            var fCondIvaNuevo = new FormularioCondicionIvaABM(TipoOperacion.Nuevo,EntidadId);
            fCondIvaNuevo.ShowDialog();

        }
    }
}
