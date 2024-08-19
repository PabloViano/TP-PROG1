using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica2
{
    public class Pago
    {
        public int NroCredito { get; set; }
        public DateTime FechaDiaPagado { get; set; }
        public LugarPago lugarPago { get; set; }
        public Pago(LugarPago lugar, int nroCredito = 0, DateTime fechaDiaPagado = default(DateTime))
        {
            this.lugarPago = lugar;
            this.NroCredito = nroCredito;
            this.FechaDiaPagado = fechaDiaPagado;

        }
    }
}
