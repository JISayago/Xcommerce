namespace XCommerce.Servicio.Core.Banco
{
    using System.Collections.Generic;
    using XCommerce.Servicio.Core.Banco.DTO;

    public interface IBancoServicio
    {
        IEnumerable<BancoDTO> Obtener(string cadenaBuscar);
        BancoDTO ObtenerPorId(long entidadId);
        void Agregar(BancoDTO banco);
        void Modificar(BancoDTO banco);
    }
}
