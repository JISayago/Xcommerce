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



        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);

            Inicializador(EntidadId);
        }

        public FormularioBajaArticuloABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();


            _motivoBajaServicio = new MotivoBajaServicio();
            _bajaArticuloServicio = new BajaArticuloServicio();

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
            //fue negado para que siga la funcion, no tengo cargar datos sera por eso?

            CargarComboBox(cmbMotivo, _motivoBajaServicio.ObtenerMotivoBaja(string.Empty), "Descripcion", "Id");

            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 99999;

            richBajaArticulo.KeyPress += Validacion.NoSimbolos;
            richBajaArticulo.KeyPress += Validacion.NoNumeros;

            nudCantidad.Focus();

            if (entidadId.HasValue) return;
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

            var bajaArticulo = _bajaArticuloServicio.ObtenerBajaMotivoPorId(entidadId.Value);

            richBajaArticulo.Text = bajaArticulo.Observacion;
            nudCantidad.Value = bajaArticulo.Cantidad;

            CargarComboBox(cmbMotivo, _motivoBajaServicio.ObtenerMotivoBaja(string.Empty), "Descripcion", "Id");
            cmbMotivo.SelectedItem = bajaArticulo.MotivoBajaId;

        }

        private void btnNuevoMotivoBaja_Click(object sender, EventArgs e)
        {
            
            var motivoBajaABM = new FormularioMotivoBajaABM(TipoOperacion.Nuevo);
            this.Close();
            motivoBajaABM.ShowDialog();
            var bajaArticuloABM = new FormularioBajaArticuloABM(TipoOperacion.Nuevo);
            bajaArticuloABM.ShowDialog();            
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
            return true;

        }
    }
}