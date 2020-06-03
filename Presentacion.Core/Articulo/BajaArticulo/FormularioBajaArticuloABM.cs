using Presentacion.Core.Articulo.MotivoBaja;
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
using XCommerce.Servicios.Core.Articulo;
using XCommerce.Servicios.Core.Articulo.BajaArticulo;
using XCommerce.Servicios.Core.Articulo.BajaArticulo.DTO;
using XCommerce.Servicios.Core.Articulo.BajaArticulo.MotivoBaja;
using XCommerce.Servicios.Core.Articulo.BajaArticulo.MotivoBaja.DTO;

namespace Presentacion.Core.Articulo.BajaArticulo
{
    public partial class FormularioBajaArticuloABM : FormularioBaseABM
    {

        private readonly IBajaArticuloServicio _bajaArticuloServicio;
        private readonly IMotivoBajaServicio _motivoBajaServicio;
        private readonly IArticuloServicio _articuloServicio;


        public FormularioBajaArticuloABM()
        {
            InitializeComponent();
        }

        public FormularioBajaArticuloABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();


            _motivoBajaServicio = new MotivoBajaServicio();
            _bajaArticuloServicio = new BajaArticuloServicio();
            _articuloServicio = new ArticuloServicio();
            /* if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
             {
                 CargarDatos(entidadId);
             }

             if (tipoOperacion == TipoOperacion.Eliminar)
             {
                 DesactivarControles(this);
             }
             */

            CargarComboBox(cmbMotivo, _motivoBajaServicio.ObtenerMotivoBaja(string.Empty), "Descripcion", "Id");

            //cuando abris motivoBajaABM y se vuelve a abrir bajaArticuloABM se piede entidadID del articulo!!!!!
            var articuloDTO = _articuloServicio.ObtenerPorId(entidadId.Value);
            lblArticulo.Text = articuloDTO.Descripcion;

            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = articuloDTO.Stock;
            nudCantidad.Value = articuloDTO.Stock;//No funca, porque? noc

            richBajaArticulo.KeyPress += Validacion.NoSimbolos;
            richBajaArticulo.KeyPress += Validacion.NoNumeros;

            nudCantidad.Focus();

        }

        public override bool EjecutarComandoNuevo()
        {
            var bajaArticuloNuevo = new BajaArticuloDTO
            {
                Cantidad = nudCantidad.Value,
                Fecha = DateTime.Now,
                Observacion = richBajaArticulo.Text,
                MotivoBajaId = (long)cmbMotivo.SelectedValue,
                ArticuloId = EntidadId.Value
            };

            _bajaArticuloServicio.Insertar(bajaArticuloNuevo);

            this.Close();

            return true;

        }

        private void btnNuevoMotivoBaja_Click(object sender, EventArgs e)
        {
            var motivoBajaABM = new FormularioMotivoBajaABM(TipoOperacion.Nuevo);
            motivoBajaABM.ShowDialog();
        }

        public override void DesactivarControles(object obj)
        {
            base.DesactivarControles(obj);

            btnLimpiar.Enabled = false;
            btnLimpiar.Visible = false;
        }

        private void FormularioBajaArticuloABM_Activated(object sender, EventArgs e)
        {
            CargarComboBox(cmbMotivo, _motivoBajaServicio.ObtenerMotivoBaja(string.Empty), "Descripcion", "Id");
        }

        /*public override void CargarDatos(long? entidadId)
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

            var bajaArticulo = _bajaArticuloServicio.ObtenerBajaMotivoPorId(entidadId.Value);

            richBajaArticulo.Text = bajaArticulo.Observacion;
            nudCantidad.Value = bajaArticulo.Cantidad;

            CargarComboBox(cmbMotivo, _motivoBajaServicio.ObtenerMotivoBaja(string.Empty), "Descripcion", "Id");
            cmbMotivo.SelectedItem = bajaArticulo.MotivoBajaId;
            
        }*/
    }
}