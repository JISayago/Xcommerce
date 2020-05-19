namespace Presentacion.FormulariosBase
{
    using Presentacion.FormulariosBase.Helpers;
    using System;
    using System.Windows.Forms;

    public partial class FormularioBaseABM : FormularioBase
    {
        protected TipoOperacion TipoOperacion;
        protected long? EntidadId;

        public bool RealizoAlgunaOperacion { get; set; }



        public FormularioBaseABM() 
        {
            InitializeComponent();
            btnSalir.Image = Constatntes.Imagenes.ImagenBotonSalir; 
        }

        public FormularioBaseABM(TipoOperacion tipoOperacion, long? entidadId) : this()
        {
            TipoOperacion = tipoOperacion;
            EntidadId = entidadId;
            RealizoAlgunaOperacion = false;

            CambiarTextoImagenBotones(tipoOperacion);
        }
                
        private void CambiarTextoImagenBotones(TipoOperacion tipoOperacion)
        {
            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                btnEjecutar.Text = "Eliminar";
                btnEjecutar.Image = Constatntes.Imagenes.ImagenBotonEliminar;
                btnLimpiar.Image = Constatntes.Imagenes.ImagenBotonLimpiar;
            }
            else
            {
                btnEjecutar.Text = "Guardar";
                btnEjecutar.Image = Constatntes.Imagenes.ImagenBotonGuardar;
                btnLimpiar.Image = Constatntes.Imagenes.ImagenBotonLimpiar;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            if (TipoOperacion == TipoOperacion.Eliminar || TipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(EntidadId);

            }
            else
            {
                Limpiar(this);
            }
        }

        public virtual void EjecutarComando()
        {
            switch (TipoOperacion)
            {
                case TipoOperacion.Nuevo:
                    if (EjecutarComandoNuevo())
                    {
                        MessageBox.Show(@"Los datos se Guardaron Correctamente.", @"Atención", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Limpiar(this);
                        RealizoAlgunaOperacion = true;
                    }
                    break;
                case TipoOperacion.Eliminar:
                    if (EjecutarComandoEliminar())
                    {
                        MessageBox.Show(@"Los datos se Eliminaron Correctamente.", @"Atención", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        RealizoAlgunaOperacion = true;
                        this.Close();
                    }
                    break;
                case TipoOperacion.Modificar:
                    if (EjecutarComandoModificar())
                    {
                        MessageBox.Show(@"Los datos se Modificaron Correctamente.", @"Atención", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        RealizoAlgunaOperacion = true;
                        this.Close();
                    }
                    break;
            }
        }

        public virtual void CargarDatos(long? entidadId)
        {
            
        }

        public virtual void Inicializador(long? entidadId)
        {
            
        }

        public virtual bool EjecutarComandoNuevo()
        {
            return false;
        }
        public virtual bool EjecutarComandoModificar()
        {
            return false;
        }

        public virtual bool EjecutarComandoEliminar()
        {
            return false;
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro de Limpiar los Datos", @"Atención", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar(this);
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            EjecutarComando();
        }

        private void FormularioBaseABM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }
    }
}
