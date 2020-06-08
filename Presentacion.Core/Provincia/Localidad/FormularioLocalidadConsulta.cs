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
using XCommerce.Servicios.Core.Localidad;
using XCommerce.Servicios.Core.Localidad.DTO;
using XCommerce.Servicios.Core.Provincia;
using XCommerce.Servicios.Core.Provincia.DTO;

namespace Presentacion.Core.Provincia.Localidad
{
    public partial class FormularioLocalidadConsulta : FormularioBaseConsulta
    {
        private readonly ILocalidadServicio _localidadServicio;

        private readonly IProvinciaServicio _provinciaServicio;
        
        public FormularioLocalidadConsulta() : this(new LocalidadServicio(),new ProvinciaServicio())
        {
            InitializeComponent();
        }

        public FormularioLocalidadConsulta(ILocalidadServicio localidadServicio,IProvinciaServicio provinciaServicio)
        {
            _localidadServicio = localidadServicio;

            _provinciaServicio = provinciaServicio;
        }

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);

           
            grilla.Columns["Descripcion"].Visible = true;

            grilla.Columns["ProvinciaDescrip"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            grilla.Columns["Descripcion"].HeaderText = "Localidad";

            
            grilla.Columns["ProvinciaDescrip"].Visible = true;

            grilla.Columns["Descripcion"].Width = 250;

            grilla.Columns["ProvinciaDescrip"].HeaderText = "Provincia";

        }



        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {

            base.ActualizarDatos(grilla, cadenaBuscar, check,toolStrip);

            if (check.Checked)
            {
                grilla.DataSource = _localidadServicio.ObtenerLocalidadEliminada(cadenaBuscar);
                
            }
            else
            {
                grilla.DataSource = _localidadServicio.ObtenerLocalidad(cadenaBuscar);
            }
        }

        
        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();

            if (puedeEjecutarComando)

            {
                var FormularioABMLocalidad = new FormularioLocalidadABM(TipoOperacion.Eliminar, entidadId);

                FormularioABMLocalidad.ShowDialog();

                ActualizarSegunOperacion(FormularioABMLocalidad.RealizoAlgunaOperacion);
            }
        }

        private void ActualizarSegunOperacion(bool realizoOperacion)
        {
            if (realizoOperacion)
            {
                ActualizarDatos(dgvGrilla, string.Empty,cbxEstaEliminado,BarraLateralBotones);
            }
        }

        public override void EjecutarBtnModificar()
        {
            base.EjecutarBtnModificar();

            if (puedeEjecutarComando)

            {
                var FormularioABMLocalidad = new FormularioLocalidadABM(TipoOperacion.Modificar, entidadId);

                FormularioABMLocalidad.ShowDialog();

                ActualizarSegunOperacion(FormularioABMLocalidad.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnNuevo()
        {
            var FormularioABMLocalidad = new FormularioLocalidadABM(TipoOperacion.Nuevo);

            FormularioABMLocalidad.ShowDialog();

            ActualizarSegunOperacion(FormularioABMLocalidad.RealizoAlgunaOperacion);
        }

    }
}

