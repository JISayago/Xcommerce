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
using XCommerce.Servicios.Core.ListaPrecio.DTO;

namespace Presentacion.Core.ListaPrecio
{
    public partial class FormularioListaPrecioABM : FormularioBaseABM
    {
        private IListaPrecioServicio _listaPrecioServicio;

        public FormularioListaPrecioABM()
        {
            InitializeComponent();
        }

        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }
        public FormularioListaPrecioABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _listaPrecioServicio = new ListaPrecioServicio();
            
            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
            }
        }

        public override bool EjecutarComandoNuevo()
        {
            var listaPrecioNueva = new ListaPrecioDTO
            {
                Descripcion = txtDescripcion.Text,
                Rentabilidad = nudRentabilidad.Value,
                EstaEliminado = false

            };
            _listaPrecioServicio.Insertar(listaPrecioNueva);
            return true;

        }
    }


}
