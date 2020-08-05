

namespace VentanaPrincipal
{
    using Presentacion.Core.Articulo;
    using Presentacion.Core.Articulo.BajaArticulo;
    using Presentacion.Core.Articulo.Marca;
    using Presentacion.Core.Articulo.Rubro;
    using Presentacion.Core.Banco;
    using Presentacion.Core.Caja;
    using Presentacion.Core.Cliente;
    using Presentacion.Core.CondicionIva;
    using Presentacion.Core.Empleado;
    using Presentacion.Core.Kiosco;
    using Presentacion.Core.ListaPrecio;
    using Presentacion.Core.Precio;
    using Presentacion.Core.Proveedor;
    using Presentacion.Core.Provincia;
    using Presentacion.Core.Provincia.Localidad;
    using Presentacion.Core.Salon;
    using Presentacion.Core.Salon.Mesa;
    using Presentacion.Core.Tarjeta;
    using Presentacion.Core.Tarjeta.PlanTarjeta;
    using Presentacion.Core.VentaSalon;
    using Presentacion.Helpers;
    using Presentacion.Login.Usuario;
    using System;
    using System.Windows.Forms;

    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();

            lblNombreUsuario.Text = DatosSistema.NombreUsuario;
            lblEstadoCaja.Text = DatosSistema.EstaCajaAbierta ? "Abierta" : "Cerrada";
        }



        private void consultaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var FormularioConsultaProvincia = new FormularioProvinciaConsulta();
            FormularioConsultaProvincia.Show();
        }



        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioConsultaEmpleado = new FormularioEmpleadoConsulta();
            FormularioConsultaEmpleado.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioUsuarios = new FormularioUsuario();
            FormularioUsuarios.Show();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioConsultaLocalidad = new FormularioLocalidadConsulta();
            FormularioConsultaLocalidad.Show();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var FormularioConsultaSalon = new FormularioSalonConsulta();
            FormularioConsultaSalon.Show();
        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var FormularioConsultaMesa = new FormularioMesaConsulta();
            FormularioConsultaMesa.Show();
        }

        private void consultaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var FormularioConsultaArticulo = new FormularioArticuloConsulta();
            FormularioConsultaArticulo.Show();
        }

        private void consultaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var FormularioventaSalon = new FormularioVentaSalon();
            FormularioventaSalon.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioConsultaMarca = new FormularioMarcaConsulta();
            FormularioConsultaMarca.Show();
        }

        private void rubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioConsultaRubro = new FormularioRubroConsulta();
            FormularioConsultaRubro.Show();
        }

        private void consultaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var FormularioConsultaCliente = new FormularioClienteConsulta();
            FormularioConsultaCliente.Show();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void consultaToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var FormularioConsultaListaPrecio = new FormularioListaPrecioConsulta();
            FormularioConsultaListaPrecio.Show();
        }

        private void agregarActualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioActualizarPrecio = new FormularioPrecio();
            FormularioActualizarPrecio.Show();

        }

        private void bajasArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioBajaArticulo = new FormularioBajaArticuloConsulta();
            FormularioBajaArticulo.Show();
        }


        private void btnKiosco_Click(object sender, EventArgs e)
        {
            var fKiosco = new FormularioKiosco(false);
            fKiosco.Show();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            var Caja = new FormularioCaja();
            Caja.Show();
        }

        private void btnVentaSalon_Click(object sender, EventArgs e)
        {
            var fVentaSalon = new FormularioVentaSalon();
            fVentaSalon.Show();
        }

        private void VentanaPrincipal_Activated(object sender, EventArgs e)
        {

            lblEstadoCaja.Text = DatosSistema.EstaCajaAbierta ? "Abierta" : "Cerrada";
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            var fDel = new FormularioKiosco(true);
            fDel.Show();
        }

        private void consultaToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            var ft = new FormularioTarjetaConsulta();
            ft.Show();

        }

        private void consultaToolStripMenuItem8_Click(object sender, EventArgs e)
        {

            var ft = new FormularioPlanTarjetaConsulta();
            ft.Show();
        }

        private void consultaToolStripMenuItem9_Click(object sender, EventArgs e)
        {

            var fCIva= new FormularioCondicionIvaConsulta();
            fCIva.Show();
        }

        private void consultaToolStripMenuItem10_Click(object sender, EventArgs e)
        {

            var fProveedor = new FormularioProveedorConsulta();
            fProveedor.Show();

        }

        private void comprobanteCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fCompra = new FormularioIngresoArticulos();
            fCompra.Show();
        }

        private void consultaToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            var f = new FormularioBancoConsulta();
            f.Show();
        }
    }
}
