using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica2;

namespace WindForm
{
    interface IPasarPrestamo
    {
        bool PasarPrestamo(Cliente cliente, ComercioAdherido comercioAdherido, Sucursal sucursal, decimal montoCredito, int cantidadCuotas);
        Cliente PasarCliente(tipoDocumento tipoDocumento, int NumeroDocumento);
        Sucursal PasarSucursal(int IDSucursal);
        ComercioAdherido PasarComercio(int IDComercio);

    }
}
