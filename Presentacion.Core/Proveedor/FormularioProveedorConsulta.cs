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
using XCommerce.Servicios.Core.Proveedor;

namespace Presentacion.Core.Proveedor
{
    public partial class FormularioProveedorConsulta : FormularioBaseConsulta
    {
        private IProveedorServicio _proveedorServicio; 
        private bool vieneDeCompra = false;
        public long proveedorSelecionaso = 0;

        public FormularioProveedorConsulta() :this(new ProveedorServicio())
        {
            InitializeComponent();
        }
        public FormularioProveedorConsulta(bool vieneDeCompra) :this (new ProveedorServicio())
        {
            InitializeComponent();
            this.vieneDeCompra = vieneDeCompra;
        }
        public FormularioProveedorConsulta(IProveedorServicio proveedorServicio)
        {
            _proveedorServicio = proveedorServicio;
        }
        public override void EjecutarDobleClickFila()
        {
            if (vieneDeCompra)
            {
                Console.WriteLine("In ClienteCons");
                proveedorSelecionaso = (long)entidadId;
                Close();
            }
        }
        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);
            grilla.Columns["RazonSocial"].Visible = true;
            grilla.Columns["RazonSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["RazonSocial"].HeaderText = "Razon Social";
            grilla.Columns["RazonSocial"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grilla.Columns["Contacto"].Visible = true;
            grilla.Columns["Contacto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Contacto"].HeaderText = "Contacto";
            grilla.Columns["Contacto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grilla.Columns["Telefono"].Visible = true;
            grilla.Columns["Telefono"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Telefono"].HeaderText = "Telefono";
            grilla.Columns["Telefono"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grilla.Columns["Email"].Visible = true;
            grilla.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Email"].HeaderText = "Email";
            grilla.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;



        }

        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {
            base.ActualizarDatos(grilla, cadenaBuscar, check, BarraLateralBotones);

      

            grilla.DataSource = _proveedorServicio.Obtener(cadenaBuscar);
            toolStrip.Enabled = true;
        }


        public override void EjecutarBtnNuevo()
        {
            var fProveedor = new FormularioProveedorABM(TipoOperacion.Nuevo);
            fProveedor.ShowDialog();
            ActualizarSegunOperacion(fProveedor.RealizoAlgunaOperacion);
        }

        public override void EjecutarBtnModificar()
        {
            base.EjecutarBtnModificar();
            if (puedeEjecutarComando)
            {
                var fProveedor = new FormularioProveedorABM(TipoOperacion.Modificar, entidadId);
                fProveedor.ShowDialog();
                ActualizarSegunOperacion(fProveedor.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();
            if (puedeEjecutarComando)
            {
                var fProveedor = new FormularioProveedorABM(TipoOperacion.Eliminar, entidadId);
                fProveedor.ShowDialog();
                ActualizarSegunOperacion(fProveedor.RealizoAlgunaOperacion);
            }
        }

        private void ActualizarSegunOperacion(bool realizoOperacion)
        {
            if (realizoOperacion)
            {
                ActualizarDatos(dgvGrilla, string.Empty, cbxEstaEliminado, BarraLateralBotones);
            }
        }

    }
}
