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
using XCommerce.Servicios.Core.Cliente;
using XCommerce.Servicios.Core.Empleado;
using XCommerce.Servicios.Core.Reserva;
using XCommerce.Servicios.Core.Reserva.DTO;
using XCommerce.Servicios.Core.Salon.Mesa;

namespace Presentacion.Core.Reserva
{
    public partial class FormularioReservaConsulta : FormularioBaseConsulta
    {
        private readonly IMesaServicio _mesaServicio;
        private readonly IClienteServicio _clienteServicio;
        private readonly IEmpleadoServicio _empleadoServicio;
        private readonly IReservaServicio _reservaServicio;
        private  long mesaID;

        public FormularioReservaConsulta(long mesaId = 0) : this(new MesaServicio(), new ReservaServicio(), new ClienteServicio(), new EmpleadoServicio())
        {
            InitializeComponent();           
            
            mesaID = mesaId;     
        }

        public FormularioReservaConsulta(IMesaServicio mesaServicio, IReservaServicio reservaServicio, IClienteServicio clienteServicio, IEmpleadoServicio empleadoServicio)
        {
            _mesaServicio = mesaServicio;
            _clienteServicio = clienteServicio;
            _empleadoServicio = empleadoServicio;
            _reservaServicio = reservaServicio;
           
        }
        
        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);

            grilla.Columns["ClienteApyNom"].Visible = true;

            grilla.Columns["ClienteApyNom"].Width = 250;

            grilla.Columns["ClienteApyNom"].HeaderText = "Reserva a nombre de";


            grilla.Columns["MesaNumero"].Visible = true;

            grilla.Columns["MesaNumero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grilla.Columns["MesaNumero"].HeaderText = "Mesa";


            grilla.Columns["FechaReserva"].Visible = true;

            grilla.Columns["FechaReserva"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grilla.Columns["FechaReserva"].HeaderText = "Fecha y Hora";


            grilla.Columns["Senia"].Visible = true;

            grilla.Columns["Senia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grilla.Columns["Senia"].HeaderText = "Senia";


            grilla.Columns["Usuario"].Visible = true;

            grilla.Columns["Usuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grilla.Columns["Usuario"].HeaderText = "Registro de Reserva";


        }



        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {

            base.ActualizarDatos(grilla, cadenaBuscar, check, toolStrip);

            IEnumerable<ReservaDTO> listasReserva;

            if (mesaID == 0) {
                listasReserva = _reservaServicio.ObtenerReservas(cadenaBuscar);
            }
            else
            {
                listasReserva = _reservaServicio.ObtenerReservasPorMesaId(mesaID);
            }
            

            foreach (ReservaDTO reserva in listasReserva)
            {
                reserva.MesaNumero = _mesaServicio.ObtenerPorId(reserva.MesaId).Numero;
                reserva.ClienteApyNom = _clienteServicio.ObtenerClientePorId(reserva.ClienteId).ApyNom;
                reserva.Usuario = _empleadoServicio.ObtenerEmpleadoPorId(reserva.UsuarioId).ApyNom;
            }

            grilla.DataSource = listasReserva;         
                  
        }

        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();

            if (puedeEjecutarComando)

            {
                var FormularioABMReserva = new FormularioReservaABM(TipoOperacion.Eliminar, entidadId);

                FormularioABMReserva.ShowDialog();

                ActualizarSegunOperacion(FormularioABMReserva.RealizoAlgunaOperacion);
            }
        }

        private void ActualizarSegunOperacion(bool realizoOperacion)
        {
            if (realizoOperacion)
            {
                ActualizarDatos(dgvGrilla, string.Empty, cbxEstaEliminado, BarraLateralBotones);
            }
        }

        public override void EjecutarBtnModificar()
        {
            base.EjecutarBtnModificar();

            if (puedeEjecutarComando)

            {
                var FormularioABMReserva = new FormularioReservaABM(TipoOperacion.Modificar, entidadId);

                FormularioABMReserva.ShowDialog();

                ActualizarSegunOperacion(FormularioABMReserva.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnNuevo()
        {
            var FormularioABMReserva = new FormularioReservaABM(TipoOperacion.Nuevo);

            FormularioABMReserva.ShowDialog();

            ActualizarSegunOperacion(FormularioABMReserva.RealizoAlgunaOperacion);
        }

        
    }
}
