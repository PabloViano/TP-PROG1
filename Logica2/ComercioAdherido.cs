using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica2
{
    public class ComercioAdherido : Edificio
    {
        public string RazonSocial { get; set; }

        public ComercioAdherido(int id, string ciudad, string direccion, int codigoPostal, string razonSocial)
        {
            this.ID = id;
            this.Ciudad = ciudad;
            this.Direccion = direccion;
            this.CP = codigoPostal;
            this.RazonSocial = razonSocial;
        }

    }
}
