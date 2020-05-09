using Presentacion.Core.Salon.Mesa.Control;
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
using XCommerce.Servicios.Core.Salon;
using XCommerce.Servicios.Core.Salon.Mesa;

namespace Presentacion.Core.VentaSalon
{
    public partial class FormularioVentaSalon : FormularioBase
    {

        private readonly ISalonServicio _salonServicio;
        private readonly IMesaServicio _mesaServicio;

        public FormularioVentaSalon()
        {
            InitializeComponent();

            _salonServicio = new SalonServicio();
            _mesaServicio = new MesaServicio();

        }


        private void CrearControles()
        {
            var contenedorPagina = new TabControl();
            var contador = 0;

            foreach (var salon in _salonServicio.ObtenerSalon(string.Empty))
            {
                var mesas = _mesaServicio.ObtenerMesaPorSalon(salon.Id, string.Empty);

                var flowPanel = new FlowLayoutPanel
                {
                    Name = $"flowPanel{salon.Id}",
                    Dock = DockStyle.Fill

                };

                foreach (var mesa in mesas)
                    
                {
                    var controlMesa = new CtrolMesa {

                        mesaId = mesa.Id,
                        Estado = mesa.estadoMesa,
                        NumeroMesa = mesa.Numero,
                        PrecioCosumido = 0m
                         
                    };
                   
                    flowPanel.Controls.Add(controlMesa);
                    
                }


                var pagina = new TabPage
                {
                    Location = new Point(4, 22),
                    Name = $"Pagina{salon.Id}",
                    Padding = new Padding(3),
                    Size = new Size(854, 357),
                    TabIndex = contador,
                    Text = $"{salon.Descripcion}",
                    UseVisualStyleBackColor = true
                };
                pagina.Controls.Add(flowPanel);
                contenedorPagina.Controls.Add(pagina);
                contador++;
            }


            contenedorPagina.Dock = DockStyle.Fill;
            contenedorPagina.Location = new Point(0, 66);
            contenedorPagina.Name = "Contenedor";
            contenedorPagina.SelectedIndex = 0;
            contenedorPagina.Size = new Size(862, 383);
            contenedorPagina.TabIndex = 9;
            contenedorPagina.ResumeLayout(false);

            this.Controls.Add(contenedorPagina);
            this.Controls.SetChildIndex(contenedorPagina, 0);
            contenedorPagina.ResumeLayout(false);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioVentaSalon_Load_1(object sender, EventArgs e)
        {
            CrearControles();
        }
    }
}
