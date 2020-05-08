using Presentacion.Core.ListaPrecio;
using Presentacion.FormulariosBase;
using Presentacion.FormulariosBase.Helpers;
using Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCommerce.Servicios.Core.Articulo;
using XCommerce.Servicios.Core.Articulo.DTO;
using XCommerce.Servicios.Core.ListaPrecio;
using XCommerce.Servicios.Core.ListaPrecio.DTO;
using XCommerce.Servicios.Core.Precio;
using XCommerce.Servicios.Core.Precio.DTO;

namespace Presentacion.Core.Articulo
{
    public partial class FormularioArticuloABM : FormularioBaseABM
    {
        private IArticuloServicio _articuloServicio;
        private IPrecioServicio _precioServicio;
        private IListaPrecioServicio _listaPrecioServicio;
        private byte[] byte_vacio_foto = { 0 }; //¿que hacía?

        public FormularioArticuloABM()
        {
            InitializeComponent();
        }

        public FormularioArticuloABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _articuloServicio = new ArticuloServicio();
            _precioServicio = new PrecioServicio();
            _listaPrecioServicio = new ListaPrecioServicio();

            CargarComboBox(cmbListaPrecio, _listaPrecioServicio.Obtener(string.Empty), "Descripcion", "Id");

            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);

                nudPrecioCosto.Enabled = false;
                nudPrecioPublico.Enabled = false;
                cmbListaPrecio.Enabled = false;
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
            }

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

            var articulo = _articuloServicio.ObtenerPorId(entidadId.Value);

            if (articulo != null)
            {
                txtBoxCodigo.Text = articulo.Codigo;
                txtBoxCodigoBarra.Text = articulo.CodigoBarra;
                txtBoxDescripcion.Text = articulo.Descripcion;
                txtBoxDetalle.Text = articulo.Detalle;
                txtBoxAbreviatura.Text = articulo.Abreviatura;
                cbxActivarLimiteVenta.Checked = articulo.ActivarLimiteVenta;
                cbxDescuentaStock.Checked = articulo.DescuentaStock;
                nudLimiteVenta.Value = articulo.LimiteVenta;
                cbxPermiteStockNegativo.Checked = articulo.PermiteStockNegativo;
                imgFotoArticulo.Image = ImagenDb.Convertir_Bytes_Imagen(articulo.Foto);

                //CargarComboBox(cmbMarca, _marcaServicio.Obtener(string.Empty), "Descripcion", "Id");
                //cmbMarca.SelectedItem = articulo.MarcaId;
                //CargarComboBox(cmbRubro, _rubroServicio.Obtener(string.Empty), "Descripcion", "Id");
                //cmbRubro.SelectedItem = articulo.RubroId;


                nudStockMax.Value = articulo.StockMaximo;
                nudStock.Value = articulo.Stock;
                nudStockMin.Value = articulo.StockMinimo;


                //Foto = byte_vacio_foto//TODO//ImagenDb.Convertir_Imagen_Bytes(imgFotoArticulo.Image),
            }
            else
            {
                MessageBox.Show(@"Ocurrio un Error Grave", @"Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        public override bool EjecutarComandoEliminar()
        {
            if (EntidadId == null) return false;

            _articuloServicio.Eliminar(EntidadId.Value);

            return true;
        }

        public override bool EjecutarComandoModificar()
        {
            var articuloAModificar = new ArticuloDTO
            {
                Id = EntidadId.Value,
                Codigo = txtBoxCodigo.Text,
                CodigoBarra = txtBoxCodigoBarra.Text,
                Descripcion = txtBoxDescripcion.Text,
                Detalle = txtBoxDetalle.Text,
                Abreviatura = txtBoxAbreviatura.Text,
                ActivarLimiteVenta = cbxActivarLimiteVenta.Checked,
                DescuentaStock = cbxDescuentaStock.Checked,
                LimiteVenta = nudLimiteVenta.Value,
                PermiteStockNegativo = cbxPermiteStockNegativo.Checked,

                ////////
                // TODO:
                //MarcaId = ((MarcaDto)cmbMarca.SelectedItem).Id,
                //RubroId = ((RubroDto)cmbRubro.SelectedItem).Id,
                ////////

                MarcaId = 1,
                RubroId = 1,
                StockMaximo = nudStockMax.Value,
                Stock = nudStock.Value,
                StockMinimo = nudStockMin.Value,

                EstaDiscontinuado = false,

                Foto = byte_vacio_foto//TODO//ImagenDb.Convertir_Imagen_Bytes(imgFotoArticulo.Image),
            };

            _articuloServicio.Modificar(articuloAModificar);

            return true;
        }

        public override bool EjecutarComandoNuevo()
        {
            //TODO
            /*
            if (!VerificarDatosObligatorios())
            {
                MessageBox.Show(@"Por favor ingrese los campos Obligatorios.", @"Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            /
            */


            var articuloNuevo = new ArticuloDTO
            {
                Codigo = txtBoxCodigo.Text,
                CodigoBarra = txtBoxCodigoBarra.Text,
                Descripcion = txtBoxDescripcion.Text,
                Detalle = txtBoxDetalle.Text,
                Abreviatura = txtBoxAbreviatura.Text,
                ActivarLimiteVenta = cbxActivarLimiteVenta.Checked,
                DescuentaStock = cbxDescuentaStock.Checked,
                LimiteVenta = nudLimiteVenta.Value,
                PermiteStockNegativo = cbxPermiteStockNegativo.Checked,

                ////////
                // TODO:
                //MarcaId = ((MarcaDto)cmbMarca.SelectedItem).Id,
                //RubroId = ((RubroDto)cmbRubro.SelectedItem).Id,
                ////////

                MarcaId = 1,
                RubroId = 1,
                StockMaximo = nudStockMax.Value,
                Stock = nudStock.Value,
                StockMinimo = nudStockMin.Value,

                EstaDiscontinuado = false,

                Foto = byte_vacio_foto//TODO//ImagenDb.Convertir_Imagen_Bytes(imgFotoArticulo.Image),

            };


            //TODO acá o abajo?
            long nuevoArticuloId = _articuloServicio.Insertar(articuloNuevo);

            var precioNuevo = new PrecioDTO
            {
                ArticuloId = nuevoArticuloId,
                PrecioCosto = nudPrecioCosto.Value,
                PrecioPublico = nudPrecioPublico.Value,
                ListaPrecioId = ((ListaPrecioDTO)cmbListaPrecio.SelectedItem).Id,
                ActivarHoraVenta = false,
                FechaActualizacion = DateTime.Now,
                HoraVenta = DateTime.Now,
            };

            _precioServicio.Insertar(precioNuevo);



            return true;
        }

        private void BtnNuevaListaPrecio_Click(object sender, EventArgs e)
        {
            var fABMListaPrecio = new FormularioListaPrecioABM(TipoOperacion.Nuevo);
            fABMListaPrecio.ShowDialog();

            CargarComboBox(cmbListaPrecio, _listaPrecioServicio.Obtener(string.Empty), "Descripcion", "Id");
        }
    }
}
