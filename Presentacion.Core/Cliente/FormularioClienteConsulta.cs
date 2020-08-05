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

namespace Presentacion.Core.Cliente
{
    public partial class FormularioClienteConsulta : FormularioBaseConsulta
    {
        private readonly IClienteServicio _clienteServicio;
        private bool vieneDeSelecFPago = false;
        public long clienteSeleccionado = 0;

        public FormularioClienteConsulta():this(new ClienteServicio())
        {
            InitializeComponent();
        }
        public FormularioClienteConsulta(bool vieneDeSelecFPago) : this(new ClienteServicio())
        {
            InitializeComponent();
            this.vieneDeSelecFPago = vieneDeSelecFPago;
        }

        public FormularioClienteConsulta(IClienteServicio clienteServicio)
        {
            _clienteServicio = clienteServicio;
        }
        public override void EjecutarDobleClickFila()
        {
            if (vieneDeSelecFPago)
            {
                Console.WriteLine("In ClienteCons");
                clienteSeleccionado = (long)entidadId;
                Close();
            }
        }
        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);

            grilla.Columns["ApyNom"].Visible = true;
            grilla.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["ApyNom"].HeaderText = "Apellido y Nombre";

            grilla.Columns["DNI"].Visible = true;
            grilla.Columns["DNI"].Width = 100;

            grilla.Columns["MontoMaximoCtaCte"].Visible = true;
            grilla.Columns["MontoMaximoCtaCte"].Width = 130;
            grilla.Columns["MontoMaximoCtaCte"].HeaderText = "Saldo Cta.Cte.";

            grilla.Columns["Email"].Visible = true;
            grilla.Columns["Email"].Width = 130;

            grilla.Columns["Celular"].Visible = true;
            grilla.Columns["Celular"].Width = 100;
        }

        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {
            base.ActualizarDatos(grilla, cadenaBuscar, check, BarraLateralBotones);

            if (check.Checked)
            {
                grilla.DataSource = _clienteServicio.ObtenerClienteEliminado(cadenaBuscar);
              
            }
            else
            {
                grilla.DataSource = _clienteServicio.ObtenerCliente(cadenaBuscar);
                
            }
        }

        private void ActualizarSegunOperacion(bool realizoOperacion)
        {
            if (realizoOperacion)
            {
                ActualizarDatos(dgvGrilla, string.Empty, cbxEstaEliminado, BarraLateralBotones);
            }
        }

        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();
            if (puedeEjecutarComando)
            {
                var FormularioABMCliente = new FormularioClienteABM(TipoOperacion.Eliminar, entidadId);
                FormularioABMCliente.ShowDialog();
                ActualizarSegunOperacion(FormularioABMCliente.RealizoAlgunaOperacion);

            }
        }
        
        public override void EjecutarBtnModificar()
        {
            base.EjecutarBtnModificar();
            if (puedeEjecutarComando)
            {
                var FormularioABMCliente = new FormularioClienteABM(TipoOperacion.Modificar, entidadId);
                FormularioABMCliente.ShowDialog();
                ActualizarSegunOperacion(FormularioABMCliente.RealizoAlgunaOperacion);

            }
        }

        public override void EjecutarBtnNuevo()
        {
            var FormularioABMCliente = new FormularioClienteABM(TipoOperacion.Nuevo);
            FormularioABMCliente.ShowDialog();
            ActualizarSegunOperacion(FormularioABMCliente.RealizoAlgunaOperacion);
        }

        private void FormularioClienteConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void brnAgregarSaldo_Click(object sender, EventArgs e)
        {
            AgregarSaldoCtaCte(entidadId);
        }

        private void AgregarSaldoCtaCte(long? clienteId)
        {
            if (clienteId == null) throw new Exception("Error al Seleccionar el Cliente");
            var Fctacte = new FormularioAgregarCtaCte((long)clienteId);
            Fctacte.ShowDialog();
        }

      
    }
}
