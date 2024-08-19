using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica2;

namespace WindForm
{
    interface IFormPrincipal
    {
        List<Cliente> ObtenerListaClientes();
        List<Prestamo> ObtenerListaPrestamos();
        List<Sucursal> ObtenerListaSucursales();
        List<ComercioAdherido> ObtenerListaComercios();
        List<LugarPago> ObtenerListaLugares();
        bool GuardarSucursal(Sucursal sucursal);
        bool GuardarComercio(ComercioAdherido comercio);
        bool GuardarLugar(LugarPago lugarPago);


    }
}
