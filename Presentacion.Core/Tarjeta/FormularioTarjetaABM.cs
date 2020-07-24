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

namespace Presentacion.Core.Tarjeta
{
    public partial class FormularioTarjetaABM : FormularioBaseABM
    {

        private readonly ITarjetaServicio _tarjetaServicio;

        public FormularioTarjetaABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _tarjetaServicio = new TarjetaServicio();
            Inicializador(entidadId);

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
            if (entidadId.HasValue) return;

        }

        public override bool EjecutarComandoEliminar()
        {
            return base.EjecutarComandoEliminar();
        }

        public override bool EjecutarComandoModificar()
        {
            return base.EjecutarComandoModificar();
        }

        public override bool EjecutarComandoNuevo()
        {
            var nuevaTarjeta = new TarjetaDTO
            {
                Descripcion = txtDescripcion.Text,
            };

            _tarjetaServicio.Agregar(nuevaTarjeta);

            return true;
        }
    }
}
