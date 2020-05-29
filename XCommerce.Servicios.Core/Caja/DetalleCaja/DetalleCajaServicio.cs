using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.Caja.DetalleCaja
{
    public class DetalleCajaServicio : IDetalleCajaServicio
    {
        public void GenerarDetalleCaja(long idCaja, decimal monto, TipoPago tipoPago)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var nuevoDetalleCaja = new AccesoDatos.DetalleCaja
                {
                    CajaId = idCaja,
                    TipoPago = tipoPago,                   
                    Monto = monto
                };
                baseDatos.DetalleCajas.Add(nuevoDetalleCaja);

                baseDatos.SaveChanges();
            }
        }
    }
    
}
