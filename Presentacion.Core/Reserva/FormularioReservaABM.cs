using Presentacion.Core.Cliente;
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
using XCommerce.Servicios.Core.Empleado;
using XCommerce.Servicios.Core.Reserva;
using XCommerce.Servicios.Core.Reserva.DTO;
using XCommerce.Servicios.Core.Salon;
using XCommerce.Servicios.Core.Salon.DTO;
using XCommerce.Servicios.Core.Salon.Mesa;
using XCommerce.Servicios.Core.Salon.Mesa.DTO;

namespace Presentacion.Core.Reserva
{
    public partial class FormularioReservaABM : FormularioBaseABM
    {
        private readonly IClienteServicio _clienteServicio;
        private readonly ISalonServicio _salonServicio;
        private readonly IEmpleadoServicio _empleadoServicio;
        private readonly IMesaServicio _mesaServicio;
        private readonly IReservaServicio _reservaServicio;
        
        private long _clienteId;

        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }

        public FormularioReservaABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _clienteServicio = new ClienteServicio();
            _salonServicio = new SalonServicio();
            _mesaServicio = new MesaServicio();
            _reservaServicio = new ReservaServicio();
            _empleadoServicio = new EmpleadoServicio();

            lblUsuarioRegistra.Text = $"Usuario Registrando Reserva: {DatosSistema.NombreUsuario}";

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

            CargarComboBox(cmbSalon, _salonServicio.ObtenerSalon(string.Empty), "Descripcion", "Id");

            if (cmbSalon.Items.Count > 0)
            {
                var salon = (SalonDTO)cmbSalon.Items[0];

                CargarComboBox(cmbMesa, _mesaServicio.ObtenerMesaPorSalon(salon.Id, string.Empty), "Descripcion", "Id");
            }

        }

        public override void DesactivarControles(object obj)
        {
            base.DesactivarControles(obj);

            btnLimpiar.Enabled = false;
            btnLimpiar.Visible = false;
        }



        private void cmbSalon_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (cmbSalon.Items.Count > 0)
            {
                CargarComboBox(cmbMesa, _mesaServicio.ObtenerMesaPorSalon(((SalonDTO)cmbSalon.SelectedItem).Id, string.Empty),
                    "Descripcion", "Id");
            }
        }


        private void btnBuscarDni_Click_1(object sender, EventArgs e)
        {
            var cliente = _clienteServicio.ObtenerClientePorDni(txtClienteDni.Text);

            if (cliente == null) throw new Exception("error al obtener el cliente");

            _clienteId = cliente.Id;

            txtApynomb.Text = cliente.ApyNom;
            txtCelular.Text = cliente.Celular;
            txtDNI.Text = cliente.Dni;

        }

        private void btnNuevoCliente_Click_1(object sender, EventArgs e)
        {
            var formularioABMCliente = new FormularioClienteABM(TipoOperacion.Nuevo);
            formularioABMCliente.ShowDialog();
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

            var reserva = _reservaServicio.ObtenerReservaPorId(entidadId.Value);
            var cliente = _clienteServicio.ObtenerClientePorId(reserva.ClienteId);
            var mesa = _mesaServicio.ObtenerPorId(reserva.MesaId);
                       
            var salon = _salonServicio.ObtenerPorId(mesa.SalonId);


            dtpFecha.Value = reserva.FechaReserva.Date;
            dtpHora.Value = Convert.ToDateTime(reserva.FechaReserva);
            txtCelular.Text = cliente.Celular;
            txtDNI.Text = cliente.Dni; 
            txtApynomb.Text = cliente.ApyNom;

            CargarComboBox(cmbSalon, _salonServicio.ObtenerSalon(salon.Descripcion), "Descripcion", "Id");

            if (cmbSalon.Items.Count > 0)
            {
                CargarComboBox(cmbMesa, _mesaServicio.ObtenerMesa(mesa.Descripcion), "Descripcion", "Id");
            }

        }


        public override bool EjecutarComandoNuevo()
        {
            string fechaReserva = dtpFecha.Value.ToString("yyyy-MM-dd");
            string horaReserva = dtpHora.Value.ToString("hh:mm:ss");
            

            var reserva = new ReservaDTO
            {
                FechaReserva = Convert.ToDateTime($"{fechaReserva} {horaReserva}") ,
                Senia = nudSenia.Value,
                EstadoReserva = "Reservado",
                MesaId = ((MesaDTO)cmbMesa.SelectedItem).Id,
                UsuarioId = DatosSistema.UsuarioId,
                ClienteId = _clienteId

            };
            _reservaServicio.GenerarReserva(reserva);
            return true;
        }

        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            _reservaServicio.Eliminar(EntidadId.Value);

            return true;
        }

        public override bool EjecutarComandoModificar()
        {
            string fechaReserva = dtpFecha.Value.ToString("yyyy-MM-dd");
            string horaReserva = dtpHora.Value.ToString("hh:mm:ss");

            var reservaModificar = new ReservaDTO
            {
                FechaReserva = Convert.ToDateTime($"{fechaReserva} {horaReserva}"),
                Senia = nudSenia.Value,
                EstadoReserva = "Reservado",
                MesaId = ((MesaDTO)cmbMesa.SelectedItem).Id,
                UsuarioId = DatosSistema.UsuarioId,
                ClienteId = _clienteId
            };
            _reservaServicio.Modificar(reservaModificar);
            return true;

        }

        
    }

}
