using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica2
{
    public class LugarPago : Edificio
    {
        public bool EsSucursal { get; set; }
        public string RazonSocial { get; set; }
        public LugarPago(int id, string ciudad, string direccion, int codigoPostal, string razonSocial, bool esSucursal)
        {
            this.ID = id;
            this.Ciudad = ciudad;
            this.Direccion = direccion;
            this.CP = codigoPostal;
            this.RazonSocial = razonSocial;
            this.EsSucursal = esSucursal;

        }

    }
}
