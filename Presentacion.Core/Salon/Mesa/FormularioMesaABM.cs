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
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Salon;
using XCommerce.Servicios.Core.Salon.Mesa;
using XCommerce.Servicios.Core.Salon.Mesa.DTO;

namespace Presentacion.Core.Salon.Mesa
{
    public partial class FormularioMesaABM : FormularioBaseABM
    {
        private readonly ISalonServicio _salonServicio;
        private readonly IMesaServicio _mesaServicio;

        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }
        public FormularioMesaABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _salonServicio = new SalonServicio();
            _mesaServicio = new MesaServicio();

            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);
                cmbSalon.Enabled = false;
                btnNuevoSalon.Enabled = false;
                cmbSalon.Enabled = false;
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
            }

            AgregarControlesObligatorios(txtDescripcion, "Descripcion");
            AgregarControlesObligatorios(txtNumeroMesa, "Numero");
            AgregarControlesObligatorios(cmbSalon, "Salon");

        }

        public override void Inicializador(long? entidadId)
        {
            if (entidadId.HasValue) return;

            CargarComboBox(cmbSalon, _salonServicio.ObtenerSalon(string.Empty), "Descripcion", "Id");

            txtDescripcion.KeyPress += Validacion.NoSimbolos;
            txtDescripcion.KeyPress += Validacion.NoNumeros;



            txtNumeroMesa.KeyPress += Validacion.NoSimbolos;
            txtNumeroMesa.KeyPress += Validacion.NoLetras;
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

            var mesa = _mesaServicio.ObtenerPorId(entidadId.Value);

            if (mesa != null)
            {
                CargarComboBox(cmbSalon, _salonServicio.ObtenerSalon(mesa.SalonDescripcion), "Descripcion", "Id");
                txtNumeroMesa.Text = Convert.ToString(mesa.Numero);
                txtDescripcion.Text = mesa.Descripcion;
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
           
           
            if (_mesaServicio.ExisteNumeroMesa(Convert.ToInt32(txtNumeroMesa.Text)))
                {                
                var mesas = _mesaServicio.ObtenerMesa(string.Empty);
                var ultimoNumero = 0;
                foreach (var mesaNumero in mesas)
                {
                    ultimoNumero = mesaNumero.Numero;
                }         

                
                MessageBox.Show($"Ya existe una mesa con ese número", @"Error Mesa", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show($"El último numero registrado es: {ultimoNumero}", @"Error Mesa", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroMesa.Clear();
                txtNumeroMesa.Text = Convert.ToString(ultimoNumero+1);
                txtNumeroMesa.Focus();
                return false;
                }
            else
            {

                var mesaNueva = new MesaDTO
                {
                    SalonId = (long)cmbSalon.SelectedValue,
                    Descripcion = txtDescripcion.Text,
                    Numero = Convert.ToInt32(txtNumeroMesa.Text),
                    SalonDescripcion = cmbSalon.Text,
                    estadoMesa = EstadoMesa.Cerrada,
                    EstaEliminado = false

                };
                _mesaServicio.Insertar(mesaNueva);
                return true;
            }

        }

        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            _mesaServicio.Eliminar(EntidadId.Value);

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
            var mesaModificar = new MesaDTO
            {
                SalonId = (long)cmbSalon.SelectedValue,
                Descripcion = txtDescripcion.Text,
                Numero = Convert.ToInt32(txtNumeroMesa.Text),
                SalonDescripcion = cmbSalon.Text,
                estadoMesa = EstadoMesa.Cerrada,
                EstaEliminado = false
            };
            _mesaServicio.Modificar(mesaModificar);

            return true;

        }

        private void btnNuevoSalon_Click(object sender, EventArgs e)
        {
            var formularioABMSalon = new FormularioSalonABM(TipoOperacion.Nuevo);
           
            formularioABMSalon.ShowDialog();
           
        }

        private void FormularioMesaABM_Activated(object sender, EventArgs e)
        {
            CargarComboBox(cmbSalon, _salonServicio.ObtenerSalon(string.Empty), "Descripcion", "Id");

        }
    }
}
