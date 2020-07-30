using System;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.FormaPago.DTO;

namespace XCommerce.Servicios.Core.FormaPago
{
    public class FormaPagoServicio : IFormaPagoServicio
    {
        public void Generar(FormaPagoDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                switch (dto.TipoFormaPago)
                {
                    case TipoFormaPago.Efectivo:
                        var nfpg_efectivo = new FormaPagoEfectivo
                        {
                            TipoFormaPago = dto.TipoFormaPago,
                            Monto = dto.Monto,
                            ComprobanteId = dto.ComprobanteId
                        };

                        context.FormasPagos.Add(nfpg_efectivo);

                        context.SaveChanges();
                        break;
                    case TipoFormaPago.Tarjeta:
                        var dto_tarjeta = dto as FormaPagoTarjetaDTO;
                        var nfpg_tarjeta = new FormaPagoTarjeta
                        {
                            TipoFormaPago = dto.TipoFormaPago,
                            Monto = dto.Monto,
                            ComprobanteId = dto.ComprobanteId,
                            Numero = dto_tarjeta.Numero,
                            Cupon = dto_tarjeta.Cupon,
                            PlanTarjetaId = dto_tarjeta.PlanTarjetaId,
                            NumeroTarjeta = dto_tarjeta.NumeroTarjeta
                        };

                        context.FormasPagos.Add(nfpg_tarjeta);

                        context.SaveChanges();
                        break;
                    case TipoFormaPago.Cheque:
                        var dto_cheque = dto as FormaPagoChequeDTO;
                        var nfpg_cheque = new FormaPagoCheque
                        {
                            TipoFormaPago = dto_cheque.TipoFormaPago,
                            Monto = dto_cheque.Monto,
                            ComprobanteId = dto_cheque.ComprobanteId,
                            BancoId = dto_cheque.BancoId,
                            Dias = dto_cheque.Dias,
                            EnteEmisor = dto_cheque.EnteEmisor,
                            FechaEmision = dto_cheque.FechaEmision,
                            Numero = dto_cheque.Numero,
                        };

                        context.FormasPagos.Add(nfpg_cheque);

                        context.SaveChanges();
                        break;
                    case TipoFormaPago.CuentaCorriente:
                        var dto_ctacte  = dto as FormaPagoCtaCteDTO;
                        var nfpg_ctacte = new FormaPagoCtaCte
                        {
                            TipoFormaPago = dto_ctacte.TipoFormaPago,
                            Monto = dto_ctacte.Monto,
                            ComprobanteId = dto_ctacte.ComprobanteId,
                            ClienteId = dto_ctacte.ClienteId
                        };
                        
                        context.FormasPagos.Add(nfpg_ctacte);

                        context.SaveChanges();
                        break;
                    default:
                        throw new Exception("no existe formapago");
                }
            }
        }
    }
}
