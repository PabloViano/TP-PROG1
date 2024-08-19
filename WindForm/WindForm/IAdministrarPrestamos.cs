using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica2;

namespace WindForm
{
    interface IAdministrarPrestamos
    {
        bool GuardarPrestamo(Cliente cliente, ComercioAdherido comercioAdherido, Sucursal sucursal, decimal montoCredito, int cantidadCuotas);
        bool EliminarPrestamo(int nroPrestamo);
        Cliente BuscarCliente(tipoDocumento tipoDocumento,int NumeroDocumento);
        Sucursal BuscarSucursal(int IDSucursal);
        ComercioAdherido BuscarComercio(int IDComercio);

    }
}
