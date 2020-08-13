using Presentacion.Core.Provincia;
using Presentacion.Core.Provincia.Localidad;
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
using XCommerce.Servicios.Core.Cliente;
using XCommerce.Servicios.Core.Cliente.DTO;
using XCommerce.Servicios.Core.Localidad;
using XCommerce.Servicios.Core.Localidad.DTO;
using XCommerce.Servicios.Core.Provincia;
using XCommerce.Servicios.Core.Provincia.DTO;
using static Presentacion.Helpers.ImagenDb;

namespace Presentacion.Core.Cliente
{
    public partial class FormularioClienteABM : FormularioBaseABM
    {
        private readonly IClienteServicio _clienteServicio;
        private readonly IProvinciaServicio _provinciaServicio;
        private readonly ILocalidadServicio _localidadServicio;

        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }

        public FormularioClienteABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _clienteServicio = new ClienteServicio();
            _provinciaServicio = new ProvinciaServicio();
            _localidadServicio = new LocalidadServicio();

            

            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
            }

            AgregarControlesObligatorios(txtApellido, "Apellido");
            AgregarControlesObligatorios(txtNombre, "Nombre");
            AgregarControlesObligatorios(txtDni, "Dni");
            AgregarControlesObligatorios(txtTelefono, "Telefono");
            AgregarControlesObligatorios(txtCuil, "Cuil");
            AgregarControlesObligatorios(txtEmail, "Email");
            AgregarControlesObligatorios(txtCalle, "Calle");
            AgregarControlesObligatorios(txtNumero, "Numero");
            AgregarControlesObligatorios(cmbLocalidad, "Localidad");
            AgregarControlesObligatorios(cmbProvincia, "Provincia");
            
            
        }

        

        public override void Inicializador(long? entidadId)
        {
            if (entidadId.HasValue) return;

            CargarComboBox(cmbProvincia, _provinciaServicio.ObtenerProvincia(string.Empty), "Descripcion", "Id");

            if (cmbProvincia.Items.Count > 0)
            {
                var provincia = (ProvinciaDTO)cmbProvincia.Items[0];

                CargarComboBox(cmbLocalidad, _localidadServicio.ObtenerLocalidadPorProvincia(provincia.Id, string.Empty), "Descripcion", "Id");
            }

           // txtMontoMaximoCtaCte.KeyPress += Validacion.NoSimbolos;
            txtMontoMaximoCtaCte.KeyPress += Validacion.NoLetras;

            txtApellido.KeyPress += Validacion.NoSimbolos;
            txtApellido.KeyPress += Validacion.NoNumeros;

            txtNombre.KeyPress += Validacion.NoSimbolos;
            txtNombre.KeyPress += Validacion.NoNumeros;

            txtDni.KeyPress += Validacion.NoSimbolos;
            txtDni.KeyPress += Validacion.NoLetras;

            txtCuil.KeyPress += Validacion.NoSimbolos;
            txtCuil.KeyPress += Validacion.NoLetras;

            txtTelefono.KeyPress += Validacion.NoSimbolos;
            txtTelefono.KeyPress += Validacion.NoLetras;

            txtCelular.KeyPress += Validacion.NoSimbolos;
            txtCelular.KeyPress += Validacion.NoLetras;

            imgFotoCliente.Image = Constantes.Imagenes.ImagenUsuario;

            txtApellido.Focus();
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

            var cliente = _clienteServicio.ObtenerClientePorId(entidadId.Value);


            txtMontoMaximoCtaCte.Text = cliente.MontoMaximoCtaCte.ToString();
            // Datos Personales          
            txtApellido.Text = cliente.Apellido;
            txtNombre.Text = cliente.Nombre;
            txtDni.Text = cliente.Dni;
            txtTelefono.Text = cliente.Telefono;
            txtCelular.Text = cliente.Celular;
            txtEmail.Text = cliente.Email;
            txtCuil.Text = cliente.Cuil;
            dtpFechaNacimiento.Value = cliente.FechaNacimiento;
            imgFotoCliente.Image = Convertir_Bytes_Imagen(cliente.Foto);

            // Datos Direccion
            txtCalle.Text = cliente.Calle;
            txtNumero.Text = cliente.Numero.ToString();
            txtPiso.Text = cliente.Piso;
            txtDepartamento.Text = cliente.Dpto;
            txtCasa.Text = cliente.Casa;
            txtLote.Text = cliente.Lote;
            txtManzana.Text = cliente.Mza;
            txtBarrio.Text = cliente.Barrio;

            CargarComboBox(cmbProvincia, _provinciaServicio.ObtenerProvincia(string.Empty), "Descripcion", "Id");

            cmbProvincia.SelectedItem = cliente.ProvinciaId;

            if (cmbProvincia.Items.Count > 0)
            {
                CargarComboBox(cmbLocalidad, _localidadServicio.ObtenerLocalidadPorProvincia(cliente.ProvinciaId, string.Empty), "Descripcion", "Id");
            }
        }

        private void cmbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbProvincia.Items.Count > 0)
            {
                CargarComboBox(cmbLocalidad, _localidadServicio.ObtenerLocalidadPorProvincia(((ProvinciaDTO)cmbProvincia.SelectedItem).Id, string.Empty),
                    "Descripcion", "Id");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (Archivo.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(Archivo.FileName))
                {
                    imgFotoCliente.Image = Image.FromFile(Archivo.FileName);
                }
                else
                {
                    imgFotoCliente.Image = Presentacion.Constantes.Imagenes.ImagenUsuario;
                }
            }
            else
            {
                imgFotoCliente.Image = Presentacion.Constantes.Imagenes.ImagenUsuario;
            }
        }

        private void btnNuevaProvincia_Click(object sender, EventArgs e)
        {

            var FormularioABMProvincia = new FormularioProvinciaABM(TipoOperacion.Nuevo);
            FormularioABMProvincia.ShowDialog();

            if (FormularioABMProvincia.RealizoAlgunaOperacion)
            {
                CargarComboBox(cmbProvincia, _provinciaServicio.ObtenerProvincia(string.Empty), "Descripcion", "Id");

                if (cmbProvincia.Items.Count > 0)
                {
                    CargarComboBox(cmbLocalidad, _localidadServicio.ObtenerLocalidadPorProvincia(((ProvinciaDTO)cmbProvincia.Items[0]).Id, string.Empty), "Descripcion", "Id");
                }
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
            var nuevoCliente = new ClienteDTO
            {
                MontoMaximoCtaCte = Convert.ToDecimal(txtMontoMaximoCtaCte.Text),
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Barrio = txtBarrio.Text,
                Calle = txtCalle.Text,
                Casa = txtCasa.Text,
                Celular = txtCelular.Text,
                Cuil = txtCuil.Text,
                Dni = txtDni.Text,
                Dpto = txtDepartamento.Text,
                Email = txtEmail.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Lote = txtLote.Text,
                Mza = txtManzana.Text,
                Numero = int.TryParse(txtNumero.Text, out var numero) ? numero : 0,
                Piso = txtPiso.Text,
                Telefono = txtTelefono.Text,
                LocalidadId = ((LocalidadDTO)cmbLocalidad.SelectedItem).Id,
                Foto = Convertir_Imagen_Bytes(imgFotoCliente.Image),
                EstaEliminado = false,
            };

            var id = _clienteServicio.Insertar(nuevoCliente);
            if (id == -1)
            {
                return false;
            }

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
            var clienteParaModificar = new ClienteDTO
            {
                Id = EntidadId.Value,
                MontoMaximoCtaCte = decimal.TryParse(txtMontoMaximoCtaCte.Text, out var monto) ? monto : 0,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Barrio = txtBarrio.Text,
                Calle = txtCalle.Text,
                Casa = txtCasa.Text,
                Celular = txtCelular.Text,
                Cuil = txtCuil.Text,
                Dni = txtDni.Text,
                Dpto = txtDepartamento.Text,
                Email = txtEmail.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Lote = txtLote.Text,
                Mza = txtManzana.Text,
                Numero = int.TryParse(txtNumero.Text, out var numero) ? numero : 0,
                Piso = txtPiso.Text,
                Telefono = txtTelefono.Text,
                LocalidadId = ((LocalidadDTO)cmbLocalidad.SelectedItem).Id,
                Foto = Convertir_Imagen_Bytes(imgFotoCliente.Image),
                EstaEliminado = false,
            };

            _clienteServicio.Modificar(clienteParaModificar);

            return true;
        }

        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            _clienteServicio.Eliminar(EntidadId.Value);

            return true;
        }

        public override void EjecutarComando()
        {
            base.EjecutarComando();
            /*
            if (TipoOperacion == TipoOperacion.Nuevo)
                nudLegajo.Value = _empleadoServicio.ObtenerSiguienteLegajo();
            */
        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            var FormularioABMLocalidad = new FormularioLocalidadABM(TipoOperacion.Nuevo);
            FormularioABMLocalidad.ShowDialog();

            if (FormularioABMLocalidad.RealizoAlgunaOperacion)
            {
                CargarComboBox(cmbLocalidad, _localidadServicio.ObtenerLocalidadPorProvincia(((ProvinciaDTO)cmbProvincia.SelectedItem).Id, string.Empty), "Descripcion", "Id");
            }
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboBox(cmbLocalidad, _localidadServicio.ObtenerLocalidadPorProvincia(((ProvinciaDTO)cmbProvincia.SelectedItem).Id, string.Empty), "Descripcion", "Id");


        }

        private void btnNuevaProvincia_Click_1(object sender, EventArgs e)
        {
            var FormularioABMProvincia = new FormularioProvinciaABM(TipoOperacion.Nuevo);
            FormularioABMProvincia.ShowDialog();

            if (FormularioABMProvincia.RealizoAlgunaOperacion)
            {
                CargarComboBox(cmbProvincia, _provinciaServicio.ObtenerProvincia(string.Empty), "Descripcion", "Id");

                if (cmbProvincia.Items.Count > 0)
                {
                    CargarComboBox(cmbLocalidad, _localidadServicio.ObtenerLocalidadPorProvincia(((ProvinciaDTO)cmbProvincia.Items[0]).Id, string.Empty), "Descripcion", "Id");
                }
            }
        }

        private void btnLocalidad_Click_1(object sender, EventArgs e)
        {
            var FormularioABMLocalidad = new FormularioLocalidadABM(TipoOperacion.Nuevo);
            FormularioABMLocalidad.ShowDialog();

            if (FormularioABMLocalidad.RealizoAlgunaOperacion)
            {
                CargarComboBox(cmbLocalidad, _localidadServicio.ObtenerLocalidadPorProvincia(((ProvinciaDTO)cmbProvincia.SelectedItem).Id, string.Empty), "Descripcion", "Id");
            }
        }
    }
}
