using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Cliente.DTO;

namespace XCommerce.Servicios.Core.Cliente
{
    public interface IClienteServicio
    {
        IEnumerable<ClienteDTO> ObtenerCliente(string cadenaBuscar);

        IEnumerable<ClienteDTO> ObtenerClienteEliminado(string cadenaBuscar);

        void AgregarSaldoCtaCte(long clienteId, decimal monto);

        ClienteDTO ObtenerClientePorId(long clienteId);

        ClienteDTO ObtenerClientePorDni(string dni);

        long Insertar(ClienteDTO clienteDto);

        long? InsertarConsumidorFinal();

        void Modificar(ClienteDTO clienteDto);

        void Eliminar(long clienteId);

        bool DescontarDeCuenta(long clienteId, decimal monto);
    }
}
