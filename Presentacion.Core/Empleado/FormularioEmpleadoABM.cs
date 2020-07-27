namespace Presentacion.Core.Empleado
{
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
    using XCommerce.Servicios.Core.Empleado;
    using XCommerce.Servicios.Core.Empleado.DTO;
    using XCommerce.Servicios.Core.Localidad;
    using XCommerce.Servicios.Core.Localidad.DTO;
    using XCommerce.Servicios.Core.Provincia;
    using XCommerce.Servicios.Core.Provincia.DTO;
    using static Presentacion.Helpers.ImagenDb;

    public partial class FormularioEmpleadoABM : FormularioBaseABM
    {
        private readonly IEmpleadoServicio _empleadoServicio;
        private readonly IProvinciaServicio _provinciaServicio;
        private readonly ILocalidadServicio _localidadServicio;

        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }
        public FormularioEmpleadoABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _empleadoServicio = new EmpleadoServicio();
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
            AgregarControlesObligatorios(nudLegajo, "Legajo");
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


                nudLegajo.Minimum = 1;
                nudLegajo.Maximum = 99999999;
                nudLegajo.Value = _empleadoServicio.ObtenerSiguienteLegajo();

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

            imgFotoEmpleado.Image = Constantes.Imagenes.ImagenUsuario;

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

            var empleado = _empleadoServicio.ObtenerEmpleadoPorId(entidadId.Value);
                   
               

            // Datos Personales
            nudLegajo.Minimum = 1;
            nudLegajo.Maximum = 9999999999;
            nudLegajo.Value = empleado.Legajo;

            txtApellido.Text = empleado.Apellido;
            txtNombre.Text = empleado.Nombre;
            txtDni.Text = empleado.Dni;
            txtTelefono.Text = empleado.Telefono;
            txtCelular.Text = empleado.Celular;
            txtEmail.Text = empleado.Email;
            txtCuil.Text = empleado.Cuil;
            dtpFechaNacimiento.Value = empleado.FechaNacimiento;
            imgFotoEmpleado.Image = Convertir_Bytes_Imagen(empleado.Foto);

            // Datos Direccion
            txtCalle.Text = empleado.Calle;
            txtNumero.Text = empleado.Numero.ToString();
            txtPiso.Text = empleado.Piso;
            txtDepartamento.Text = empleado.Dpto;
            txtCasa.Text = empleado.Casa;
            txtLote.Text = empleado.Lote;
            txtManzana.Text = empleado.Mza;
            txtBarrio.Text = empleado.Barrio;

            CargarComboBox(cmbProvincia, _provinciaServicio.ObtenerProvincia(string.Empty), "Descripcion", "Id");

            cmbProvincia.SelectedItem = empleado.ProvinciaId;

            if (cmbProvincia.Items.Count > 0)
            {
                CargarComboBox(cmbLocalidad, _localidadServicio.ObtenerLocalidadPorProvincia(empleado.ProvinciaId, string.Empty), "Descripcion", "Id");
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
                    imgFotoEmpleado.Image = Image.FromFile(Archivo.FileName);
                }
                else
                {
                    imgFotoEmpleado.Image = Presentacion.Constantes.Imagenes.ImagenUsuario;
                }
            }
            else
            {
                imgFotoEmpleado.Image = Presentacion.Constantes.Imagenes.ImagenUsuario;
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
            var nuevoEmpleado = new EmpleadoDTO
            {
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Legajo = (int)nudLegajo.Value,
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
                Foto = Convertir_Imagen_Bytes(imgFotoEmpleado.Image),
                EstaEliminado = false,
                FechaIngreso = dtpFechaIngreso.Value
            };

            var id =  _empleadoServicio.Insertar(nuevoEmpleado);
            if(id == -1)
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
            var empleadoParaModificar = new EmpleadoDTO
            {
                Id = EntidadId.Value,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Legajo = (int)nudLegajo.Value,
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
                Foto = Convertir_Imagen_Bytes(imgFotoEmpleado.Image),
                EstaEliminado = false,
                FechaIngreso = dtpFechaIngreso.Value
            };

            _empleadoServicio.Modificar(empleadoParaModificar);

            return true;
        }

        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            _empleadoServicio.Eliminar(EntidadId.Value);

            return true;
        }

        public override void EjecutarComando()
        {
            base.EjecutarComando();

            if (TipoOperacion == TipoOperacion.Nuevo)
                nudLegajo.Value = _empleadoServicio.ObtenerSiguienteLegajo();
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
    }

}

