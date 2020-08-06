using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Comprobante;
using XCommerce.Servicios.Core.Comprobante.DTO;

namespace Presentacion.Core.Comprobante
{
    public partial class FormularioComprobante : Form
    {
        private readonly IComprobanteServicio _compobanteServicio;
        ComprobanteFacturaDTO comprobante;

        private string Tipo_Astring()
        {
            switch (comprobante.Tipo)
            {
                case TipoComprobante.A: return "A";
                case TipoComprobante.B: return "B";
                case TipoComprobante.C: return "C";
                case TipoComprobante.X: return "X";
                default: throw new Exception("error grave");

            }
        }
        public FormularioComprobante(long comprobanteId)
        {
            InitializeComponent();

            _compobanteServicio = new ComprobanteServicio();
            comprobante = _compobanteServicio.ObtenerPorId(comprobanteId);

            dataGridView1.DataSource = comprobante.Items;
            lblFecha.Text = comprobante.Fecha.ToString("dd/MM/yyyy");
            lblHora.Text = comprobante.Fecha.ToString("hh:mm");
            lblDescuento.Text = comprobante.Descuento.ToString();
            lblSubTotal.Text = comprobante.Total.ToString();
            lblTotal.Text = comprobante.SubTotal.ToString();
            lblNumero.Text = comprobante.Numero.ToString();
            lblFacturaTipo.Text = Tipo_Astring();


            lblCliente.Text = $"{comprobante.NombreCliente} {comprobante.ApellidoCliente}";
            lblEmpleado.Text = $"{comprobante.NombreEmpleado} {comprobante.ApellidoEmpleado}";
            lblForma.Text = $"{comprobante.FormaPagoStr}";

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Visible = false;
            }
            dataGridView1.Columns["CantidadProducto"].Visible = true;
            dataGridView1.Columns["CantidadProducto"].Width = 75;
            dataGridView1.Columns["CantidadProducto"].HeaderText = "Cantidad";
            dataGridView1.Columns["PrecioUnitario"].Visible = true;
            dataGridView1.Columns["PrecioUnitario"].Width = 100;
            dataGridView1.Columns["PrecioUnitario"].HeaderText = "Precio Unidad";

            dataGridView1.Columns["DescripcionProducto"].Visible = true;
            dataGridView1.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["DescripcionProducto"].HeaderText = "Concepto";

            //todo va?
            //dataGridView1.Columns["SubtotalLinea"].Visible = true;
            //dataGridView1.Columns["SubtotalLinea"].Width = 125;
            //dataGridView1.Columns["SubtotalLinea"].HeaderText = "";

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            btn_print.Visible = false;
            CaptureScreen();
            printDocument1.DocumentName = string.Format("Comprobante{0}", comprobante.Id);
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            btn_print.Visible = true;
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
