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
using XCommerce.Servicios.Core.Cliente;
using XCommerce.Servicios.Core.Cliente.DTO;
using XCommerce.Servicios.Core.DetalleCaja;
using XCommerce.Servicios.Core.DetalleCaja.DTO;

namespace Presentacion.Core.Cliente
{
    public partial class FormularioAgregarCtaCte : Form
    {
        private readonly IClienteServicio _clienteServicio;
        private readonly IDetalleCajaServicio _detalleCajaServicio;
        private ClienteDTO cliente;
        private bool Bandera;
        private int Contador;
        private decimal TotalCtaCte;
        private string clienteApyNomb;
        private decimal Diferencia;

        public FormularioAgregarCtaCte()
        {
            InitializeComponent();

            _clienteServicio = new ClienteServicio();
            _detalleCajaServicio = new DetalleCajaServicio();
            cliente = new ClienteDTO();
            Bandera = false;
            
        }

        public FormularioAgregarCtaCte(long clienteId) :this()
        {

            obtenerCliente(clienteId);

        }

        private ClienteDTO obtenerCliente(long clienteid)
        {
            cliente = _clienteServicio.ObtenerClientePorId(clienteid);
            TotalCtaCte = cliente.MontoMaximoCtaCte;
            clienteApyNomb = cliente.ApyNom;
            lblCliente.Text = "Cliente:";
            lblSaldoActual.Text = "Saldo Actual:";
            lblSaldoActual.Text = lblSaldoActual.Text + $" {TotalCtaCte}";
            lblCliente.Text = lblCliente.Text + $" {clienteApyNomb}";
            return cliente;
        }

        private void btndeshacer_Click(object sender, EventArgs e)
        {
            if (Bandera && Contador == 1)
            {
                _clienteServicio.DescontarDeCuenta(cliente.Id,Diferencia);               
                Contador = 2;
                obtenerCliente(cliente.Id);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Bandera = true;
            Diferencia = Convert.ToDecimal(txtAgregarSaldo.Text);
            _clienteServicio.AgregarSaldoCtaCte(cliente.Id, Diferencia);
            Contador = 1;
            obtenerCliente(cliente.Id);


            DetalleCajaDTO detalleCaja = new DetalleCajaDTO
            {
                CajaId = DatosSistema.CajaId,
                Monto = Diferencia,
                TipoPago = TipoPago.Efectivo
            };
            _detalleCajaServicio.Generar(detalleCaja);


        }

       
    }
}
