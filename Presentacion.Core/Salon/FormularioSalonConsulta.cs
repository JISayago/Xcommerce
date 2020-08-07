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
using XCommerce.Servicios.Core.ListaPrecio;
using XCommerce.Servicios.Core.Salon;

namespace Presentacion.Core.Salon
{
    public partial class FormularioSalonConsulta : FormularioBaseConsulta
    {
        private readonly ISalonServicio _salonServicio;
        private readonly IListaPrecioServicio _listaPrecioServicio;

        public FormularioSalonConsulta() : this(new SalonServicio(),new ListaPrecioServicio())
        {
            InitializeComponent();
        }

        public FormularioSalonConsulta(ISalonServicio salonServicio,IListaPrecioServicio listaPrecioServicio)
        {
            _salonServicio = salonServicio;
            _listaPrecioServicio = listaPrecioServicio;
        }

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);


            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Descripcion"].HeaderText = "Salon";

            grilla.Columns["listaPrecioDescripcion"].Visible = true;
            grilla.Columns["listaPrecioDescripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["listaPrecioDescripcion"].HeaderText = "Lista Precio";
        }

        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {

            base.ActualizarDatos(grilla, cadenaBuscar, check, toolStrip);

            if (check.Checked)
            {
                grilla.DataSource = _salonServicio.ObtenerSalonEliminado(cadenaBuscar);
                
            }
            else
            {
                grilla.DataSource = _salonServicio.ObtenerSalon(cadenaBuscar);
              
            }




        }

        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();
            if (puedeEjecutarComando)
            {
                var FormularioABMSalon = new FormularioSalonABM(TipoOperacion.Eliminar, entidadId);
                FormularioABMSalon.ShowDialog();
                ActualizarSegunOperacion(FormularioABMSalon.RealizoAlgunaOperacion);
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
                var FormularioABMSalon = new FormularioSalonABM(TipoOperacion.Modificar, entidadId);
                FormularioABMSalon.ShowDialog();
                ActualizarSegunOperacion(FormularioABMSalon.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnNuevo()
        {
            var FormularioABMSalon = new FormularioSalonABM(TipoOperacion.Nuevo);
            FormularioABMSalon.ShowDialog();
            ActualizarSegunOperacion(FormularioABMSalon.RealizoAlgunaOperacion);
        }

    }
}

