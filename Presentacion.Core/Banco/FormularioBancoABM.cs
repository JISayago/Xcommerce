namespace Presentacion.Core.Banco
{
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
    using XCommerce.Servicio.Core.Banco;
    using XCommerce.Servicio.Core.Banco.DTO;

    public partial class FormularioBancoABM : FormularioBaseABM
    {
        private readonly IBancoServicio _bancoServicio;


        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }
        public FormularioBancoABM(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _bancoServicio = new BancoServicio();

            if (tipoOperacion == TipoOperacion.Eliminar || tipoOperacion == TipoOperacion.Modificar)
            {
                CargarDatos(entidadId);
            }

            if (tipoOperacion == TipoOperacion.Eliminar)
            {
                DesactivarControles(this);
            }
            AgregarControlesObligatorios(txtBanco, "Banco");


        }

        public override void Inicializador(long? entidadId)
        {
            if (entidadId.HasValue) return;

            txtBanco.KeyPress += Validacion.NoSimbolos;
            txtBanco.KeyPress += Validacion.NoNumeros;
        }


        public override void DesactivarControles(object obj)
        {
            base.DesactivarControles(obj);

            btnLimpiar.Enabled = false;
            btnLimpiar.Visible = false;
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

            var banco = _bancoServicio.ObtenerPorId(entidadId.Value);

            if (banco != null)
            {
                txtBanco.Text = banco.Descripcion;
            }
            else
            {
                MessageBox.Show(@"Ocurrio un Error Grave", @"Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        public override bool EjecutarComandoNuevo()
        {
            if (!VerificarDatosObligatorios())
            {
                MessageBox.Show(@"Por favor ingrese los campos Obligatorios.", @"Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            var bancoNueva = new BancoDTO
            {
                Descripcion = txtBanco.Text,
            };
            _bancoServicio.Agregar(bancoNueva);
            return true;

        }
        public override bool EjecutarComandoEliminar()
        {

            if (EntidadId == null) return false;

            //_bancoServicio.Eliminar(EntidadId.Value);

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

            var bancoModificar = new BancoDTO
            {
                Id = EntidadId.Value,
                Descripcion = txtBanco.Text,
            };
            _bancoServicio.Modificar(bancoModificar);

            return true;

        }
    }
}

