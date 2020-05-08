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
using XCommerce.Servicios.Core.Precio.DTO;

namespace Presentacion.Core.Precio
{
    public partial class HistorialPrecio : Form
    {
        private IPrecioServicio _precioServicio;
        public HistorialPrecio(long idArticulo, long idListaPrecio)
        {
            InitializeComponent();
            _precioServicio = new PrecioServicio();

            var precios = (List<PrecioDTO>)_precioServicio.ObtenerPorArticulo(idArticulo, idListaPrecio);
            
            if (precios.Any())
            {
                dgvGrilla.DataSource = precios;
                ResetearGrilla();
            }
            else
            {
                MessageBox.Show(@"Este artículo no tiene precios agregados en esta lista precio.", @"Atención", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
         
            }
        }

        public void ResetearGrilla()
        {
            for (int i = 0; i < dgvGrilla.ColumnCount; i++)
            {
                dgvGrilla.Columns[i].Visible = false;
            }

            dgvGrilla.Columns["FechaActualizacion"].Visible = true;
            dgvGrilla.Columns["FechaActualizacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["FechaActualizacion"].HeaderText = "Fecha";

            //dgvGrilla.Columns["NombreListaPrecio"].Visible = true;
            //dgvGrilla.Columns["NombreListaPrecio"].Width = 100;
            //dgvGrilla.Columns["NombreListaPrecio"].HeaderText = "Lista Precio";

            dgvGrilla.Columns["PrecioCosto"].Visible = true;
            dgvGrilla.Columns["PrecioCosto"].Width = 50;
            dgvGrilla.Columns["PrecioCosto"].HeaderText = "Precio Costo";

            dgvGrilla.Columns["PrecioPublico"].Visible = true;
            dgvGrilla.Columns["PrecioPublico"].Width = 50;
            dgvGrilla.Columns["PrecioPublico"].HeaderText = "Precio Publico";


        }
    }
}
