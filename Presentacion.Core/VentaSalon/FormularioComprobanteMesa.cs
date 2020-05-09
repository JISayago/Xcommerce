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
using XCommerce.Servicios.Core.Empleado.Mozo;
using XCommerce.Servicios.Core.Producto;

namespace Presentacion.Core.VentaSalon
{
    public partial class FormularioComprobanteMesa : FormularioBase
    {
        private readonly long _mesaId;

        private readonly IComprobanteSalonServicio _comprobanteSalonServicio;

        private readonly IProductoServicio _productoServicio;

        private readonly IMozoServicio _mozoServicio;


        public FormularioComprobanteMesa() : this(new ComprobanteSalonServicio(), new ProductoServicio(), new MozoServicio())
        {
            InitializeComponent();


        }
        public FormularioComprobanteMesa(IComprobanteSalonServicio comprobanteSalonServicio, IProductoServicio productoServicio,IMozoServicio mozoServicio)
        {
            _comprobanteSalonServicio = comprobanteSalonServicio;
            _productoServicio = productoServicio;
            _mozoServicio = mozoServicio;


        }

     
        public void ResetearGrilla(DataGridView grilla)
        {
            for (int i = 0; i < grilla.ColumnCount; i++)
            {
                grilla.Columns[i].Visible = false;
            }

            grilla.Columns["CodigoProducto"].Visible = true;
            grilla.Columns["CodigoProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["CodigoProducto"].HeaderText = "Codigo del Producto";

            grilla.Columns["DescripcionProducto"].Visible = true;
            grilla.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["DescripcionProducto"].HeaderText = "Descripcion";

            grilla.Columns["CantidadProducto"].Visible = true;
            grilla.Columns["CantidadProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["CantidadProducto"].HeaderText = "Cantidad";

            grilla.Columns["PrecioUnitario"].Visible = true;
            grilla.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";

            grilla.Columns["SubtotalLinea"].Visible = true;
            grilla.Columns["SubtotalLinea"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["SubtotalLinea"].HeaderText = "Sub-Total";

        }


        public FormularioComprobanteMesa(long mesaId, int _numeroMesa):this()
        {
            this.Text = $"Venta -- Mesa: {_numeroMesa}";
            _mesaId = mesaId;


            ObtenerComprobanteMesa(mesaId);
            ResetearGrilla(dgvGrilla);
           
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

            

        }


        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                if (string.IsNullOrEmpty(txtCodigoBarras.Text))
                {
                    MessageBox.Show("Por favor ingrese un codigo");
                    return;
                }
                var producto = _productoServicio.ObtenerPorCodigo(_mesaId, txtCodigoBarras.Text);

                if(producto != null)
                {
                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecioUnitario.Text = Convert.ToString(producto.Precio);
                    _comprobanteSalonServicio.AgregarItems(_mesaId, nudCantidadArticulo.Value, producto);

                    ObtenerComprobanteMesa(_mesaId);
                }
            }
        }

        private void txtMozoLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                if (string.IsNullOrEmpty(txtMozoLegajo.Text))
                {
                    MessageBox.Show("Por favor ingrese un legajo");
                    return;
                }
                
                var mozo = _mozoServicio.ObtenerMozoPorLegajo(Convert.ToInt32(txtMozoLegajo.Text));

                if (mozo != null)
                {
                    txtMozoLegajo.Text = Convert.ToString(mozo.Legajo);
                    txtApyNomMozo.Text = mozo.ApyNom;
                   _mozoServicio.asignarMozoAMesa(_mesaId,mozo);



                }
            }
        }
    }
}
