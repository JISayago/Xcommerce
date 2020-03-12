using Presentacion.FormulariosBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCommerce.Servicios.Core.Comprobante;

namespace Presentacion.Core.VentaSalon
{
    public partial class FormularioComprobanteMesa : FormularioBase
    {
        private readonly long _mesaId;

        private readonly IComprobanteSalonServicio _comprobanteSalonServicio;


        public FormularioComprobanteMesa():this(new ComprobanteSalonServicio())
        {
            InitializeComponent();


        }
        public FormularioComprobanteMesa(IComprobanteSalonServicio comprobanteSalonServicio)
        {
            _comprobanteSalonServicio = comprobanteSalonServicio;


        }
        public FormularioComprobanteMesa(long mesaId, int _numeroMesa):this()
        {
            this.Text = $"Venta -- Mesa: {_numeroMesa}";
            _mesaId = mesaId;


            ObtenerComprobanteMesa(mesaId);
           
        }

        private void ObtenerComprobanteMesa(long mesaId)
        {
            var comprobanteMesaDTO = _comprobanteSalonServicio.Obtener(mesaId);

            if(comprobanteMesaDTO == null)
            {
                MessageBox.Show("Ocurrió un Error");
                this.Close();
            }

            txtMozoLegajo.Text = Convert.ToString(comprobanteMesaDTO.Legajo);
            txtApyNomMozo.Text = comprobanteMesaDTO.ApyNomMozo;
            

            nudSubTotal.Value = comprobanteMesaDTO.SubTotal;
            nudDescuento.Value = comprobanteMesaDTO.Descuento;
            nudTotal.Value = comprobanteMesaDTO.Total;

            dgvGrilla.DataSource = comprobanteMesaDTO.Items.ToList();

            formatearGrillaVenta();

        }

        private void formatearGrillaVenta()
        {
           
        }
    }
}
