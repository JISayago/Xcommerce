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
using XCommerce.Servicios.Core.Precio;

namespace Presentacion.Core.Precio
{
    public partial class FormularioPrecio : FormularioBase
    {
        private IPrecioServicio _precioServicio;
        long? entidadId = null;


        public FormularioPrecio() : this(new PrecioServicio())
        {
        }

        public FormularioPrecio(IPrecioServicio precioServicio)
        {
            InitializeComponent();

            _precioServicio = precioServicio;

            dgvGrilla.DataSource = _precioServicio.ObtenerUltimaActualizacion("");
            ResetearGrilla();
          
        }

        public void ResetearGrilla()
        {
            for (int i = 0; i < dgvGrilla.ColumnCount; i++)
            {
                dgvGrilla.Columns[i].Visible = false;
            }

            //TODO: dto traiga codigo barra
            //dgvGrilla.Columns["Codigo"].Visible = true;
            //dgvGrilla.Columns["Codigo"].Width = 80;
            //dgvGrilla.Columns["Codigo"].HeaderText = "Código";

            dgvGrilla.Columns["Id"].Visible = true;
            dgvGrilla.Columns["Id"].Width = 20;


            dgvGrilla.Columns["DescripcionArticulo"].Visible = true;
            dgvGrilla.Columns["DescripcionArticulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["DescripcionArticulo"].HeaderText = "Artículo";


            dgvGrilla.Columns["NombreListaPrecio"].Visible = true;
            dgvGrilla.Columns["NombreListaPrecio"].Width = 100;
            dgvGrilla.Columns["NombreListaPrecio"].HeaderText = "Lista Precio";

            dgvGrilla.Columns["PrecioCosto"].Visible = true;
            dgvGrilla.Columns["PrecioCosto"].Width = 100;
            dgvGrilla.Columns["PrecioCosto"].HeaderText = "Precio Costo";

            dgvGrilla.Columns["PrecioPublico"].Visible = true;
            dgvGrilla.Columns["PrecioPublico"].Width = 100;
            dgvGrilla.Columns["PrecioPublico"].HeaderText = "Precio Publico";


            dgvGrilla.Columns["FechaActualizacion"].Visible = true;
            dgvGrilla.Columns["FechaActualizacion"].Width = 100;
            dgvGrilla.Columns["FechaActualizacion"].HeaderText = "Ultima Actualizacion";

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            var fActualizarPrecio = new FormularioActualizarPrecio(TipoOperacion.Modificar, entidadId);
            fActualizarPrecio.ShowDialog();
        }

        private void DgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            entidadId = (long?)dgvGrilla["Id", e.RowIndex].Value;


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = _precioServicio.ObtenerUltimaActualizacion(txtBuscar.Text);
        }
    }
}
