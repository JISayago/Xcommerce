using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Proveedor.DTO;

namespace XCommerce.Servicios.Core.Proveedor
{
    public interface IProveedorServicio
    {
        IEnumerable<ProveedorDTO> Obtener(string cadenaBuscar);

        ProveedorDTO ObtenerRazonSocial(string razonSocial);

        ProveedorDTO ObtenerPorId(long ProveedorId);       

        long Insertar(ProveedorDTO Proveedordto);

        void Modificar(ProveedorDTO Proveedordto);

        void Eliminar(long ProveedorId);
    }
}
