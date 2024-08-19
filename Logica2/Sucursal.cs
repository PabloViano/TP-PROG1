using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica2
{
    public class Sucursal : Edificio
    {
        public int TasaInteres { get; set; }

        public Sucursal(int id, string ciudad, string direccion, int codigoPostal, int tasaInteres)
        {
            this.ID = id;
            this.Ciudad = ciudad;
            this.Direccion = direccion;
            this.CP = codigoPostal;
            this.TasaInteres = tasaInteres;
        }
    }
}
