using Presentacion.Core.Articulo.Marca;
using Presentacion.Core.Articulo.Rubro;
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
using XCommerce.Servicios.Core.Articulo.Marca;
using XCommerce.Servicios.Core.Articulo.Marca.DTO;
using XCommerce.Servicios.Core.Articulo.Rubro;
using XCommerce.Servicios.Core.Articulo.Rubro.DTO;
using XCommerce.Servicios.Core.ListaPrecio;
using XCommerce.Servicios.Core.ListaPrecio.DTO;
using XCommerce.Servicios.Core.Precio;
using XCommerce.Servicios.Core.Precio.DTO;
using static Presentacion.Helpers.ImagenDb;

namespace Presentacion.Core.Articulo
{
    public partial class FormularioArticuloABM : FormularioBaseABM
    {
        private IArticuloServicio _articuloServicio;
        private IPrecioServicio _precioServicio;
        private IListaPrecioServicio _listaPrecioServicio;
        private IMarcaServicio _marcaServicio;
        private IRubroServicio _rubroServicio;

      

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
            _marcaServicio = new MarcaServicio();
            _rubroServicio = new RubroServicio();

            CargarComboBox(cmbListaPrecio, _listaPrecioServicio.Obtener(string.Empty), "Descripcion", "Id");
            CargarComboBox(cmbMarca, _marcaServicio.ObtenerMarca(string.Empty), "Descripcion", "Id");
            CargarComboBox(cmbRubro, _rubroServicio.ObtenerRubro(string.Empty), "Descripcion", "Id");

            imgFotoArticulo.Image = Constantes.Imagenes.ImagenUsuario;

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
            if (tipoOperacion == TipoOperacion.Modificar)
            {
                nudStock.ReadOnly = true;
            }
            if(tipoOperacion == TipoOperacion.Nuevo)
            {
                nudStock.Enabled = false;
            }


            AgregarControlesObligatorios(txtBoxCodigo, "Codigo");
            AgregarControlesObligatorios(txtBoxCodigoBarra, "Codigo Barra");
            AgregarControlesObligatorios(txtBoxDescripcion, "Descripcion");
            AgregarControlesObligatorios(txtBoxDetalle, "Detalle");
            AgregarControlesObligatorios(txtBoxAbreviatura, "Abreviatura");
            AgregarControlesObligatorios(cmbMarca, "Marca");
            AgregarControlesObligatorios(cmbRubro, "Rubro");
            AgregarControlesObligatorios(cmbListaPrecio, "Lista");
          


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

                CargarComboBox(cmbMarca, _marcaServicio.ObtenerMarca(string.Empty), "Descripcion", "Id");
                cmbMarca.SelectedItem = articulo.MarcaId;
                CargarComboBox(cmbRubro, _rubroServicio.ObtenerRubro(string.Empty), "Descripcion", "Id");
                cmbRubro.SelectedItem = articulo.RubroId;

                nudStockMax.Value = articulo.StockMaximo;
                nudStock.Value = articulo.Stock;
                nudStockMin.Value = articulo.StockMinimo;

                
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
            if (!VerificarDatosObligatorios())
            {
                MessageBox.Show(@"Por favor ingrese los campos Obligatorios.", @"Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
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
                MarcaId = ((MarcaDTO)cmbMarca.SelectedItem).Id,
                RubroId = ((RubroDTO)cmbRubro.SelectedItem).Id,
                StockMaximo = nudStockMax.Value,
                Stock = nudStock.Value,
                StockMinimo = nudStockMin.Value,
                EstaDiscontinuado = false,
                Foto = Convertir_Imagen_Bytes(imgFotoArticulo.Image),
            };

            _articuloServicio.Modificar(articuloAModificar);

            return true;
        }

        public override bool EjecutarComandoNuevo()
        {
            if (!VerificarDatosObligatorios())
            {
                MessageBox.Show(@"Por favor ingrese los campos Obligatorios.", @"Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }


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
                MarcaId = ((MarcaDTO)cmbMarca.SelectedItem).Id,
                RubroId = ((RubroDTO)cmbRubro.SelectedItem).Id,
                StockMaximo = nudStockMax.Value,
                Stock = nudStock.Value,
                StockMinimo = nudStockMin.Value,
                EstaDiscontinuado = false,
                Foto = Convertir_Imagen_Bytes(imgFotoArticulo.Image)
                

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

       

        private void btnAgregarImagen_Click_1(object sender, EventArgs e)
        {
            if (Archivo.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(Archivo.FileName))
                {
                    imgFotoArticulo.Image = Image.FromFile(Archivo.FileName);
                }
                else
                {
                    imgFotoArticulo.Image = Constantes.Imagenes.ImagenBotonBuscar;
                }
            }
            else
            {
                imgFotoArticulo.Image = Constantes.Imagenes.ImagenBotonBuscar;
            }
        }

        private void btnNuevaProvincia_Click(object sender, EventArgs e)
        {
            var MarcaABM = new FormularioMarcaABM(TipoOperacion.Nuevo);
            MarcaABM.ShowDialog();
        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            var RubroABM = new FormularioRubroABM(TipoOperacion.Nuevo);           
            RubroABM.ShowDialog();
        }

        private void FormularioArticuloABM_Activated(object sender, EventArgs e)
        {
            CargarComboBox(cmbListaPrecio, _listaPrecioServicio.Obtener(string.Empty), "Descripcion", "Id");
            CargarComboBox(cmbRubro, _rubroServicio.ObtenerRubro(string.Empty), "Descripcion", "Id");
            CargarComboBox(cmbMarca, _marcaServicio.ObtenerMarca(string.Empty), "Descripcion", "Id");

        }
    }
}
