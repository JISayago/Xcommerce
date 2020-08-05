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
using XCommerce.Servicios.Core.Tarjeta;
using XCommerce.Servicios.Core.Tarjeta.DTO;
using XCommerce.Servicios.Core.Tarjeta.PlanTarjeta;
using XCommerce.Servicios.Core.Tarjeta.PlanTarjeta.DTO;

namespace Presentacion.Core.Tarjeta.PlanTarjeta
{
    public partial class FormularioPlanTarjetaABM : FormularioBaseABM
    {
        private readonly IPlanTarjetaServicio _plantarjetaServicio;

        private readonly ITarjetaServicio _tarjetaServicio;

        public FormularioPlanTarjetaABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();
            _tarjetaServicio = new TarjetaServicio();
            _plantarjetaServicio = new PlanTarjetaServicio();
            
            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
            }
;

            AgregarControlesObligatorios(txtDescripcion, "Descripción");
            AgregarControlesObligatorios(nudAlicuota, "Alicuota");
            AgregarControlesObligatorios(cmbTarjeta, "Tarjeta");

            CargarComboBox(cmbTarjeta, _tarjetaServicio.Obtener(""), "Descripcion", "Id");



            Inicializador(entidadId);
        }

        public override void Inicializador(long? entidadId)
        {
            if (entidadId.HasValue) return;

            // Asignando un Evento

            txtDescripcion.Focus();
            CargarComboBox(cmbTarjeta, _tarjetaServicio.Obtener(string.Empty), "Descripcion", "Id");

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

            var plantarjeta = _plantarjetaServicio.ObtenerPorId(entidadId.Value);

            CargarComboBox(cmbTarjeta, _tarjetaServicio.Obtener(string.Empty), "Descripcion", "Id");

            // Datos Personales
            txtDescripcion.Text = plantarjeta.Descripcion;
        }

        public override bool EjecutarComandoNuevo()
        {
            if (!VerificarDatosObligatorios())
            {
                MessageBox.Show(@"Por favor ingrese los campos Obligatorios.", @"Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            var nuevaPlanTarjeta = new PlanTarjetaDTO
            {
                Descripcion = txtDescripcion.Text,
                Alicuota = nudAlicuota.Value,
                TarjetaId = ((TarjetaDTO)cmbTarjeta.SelectedItem).Id
            };

            _plantarjetaServicio.Agregar(nuevaPlanTarjeta);

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

            var plantarjetaParaModificar = new PlanTarjetaDTO
            {
                Id = EntidadId.Value,
                Descripcion = txtDescripcion.Text,
                Alicuota = nudAlicuota.Value,
                TarjetaId = ((TarjetaDTO)cmbTarjeta.SelectedItem).Id
            };

            _plantarjetaServicio.Modificar(plantarjetaParaModificar);

            return true;
        }

        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            //Todo no tiene estaeliminado
            //_plantarjetaServicio.Eliminar();

            return true;
        }

        private void btnAgregarTarjeta_Click(object sender, System.EventArgs e)
        {
            var fTarjeta = new FormularioTarjetaABM(TipoOperacion.Nuevo);
            fTarjeta.ShowDialog();
            if (fTarjeta.RealizoAlgunaOperacion)
                CargarComboBox(cmbTarjeta, _tarjetaServicio.Obtener(string.Empty), "Descripcion", "Id");

        }
    }
}
