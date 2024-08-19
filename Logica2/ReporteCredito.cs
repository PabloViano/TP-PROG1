using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica2
{
    public class ReporteCredito
    {
        public int NroCuotas { get; set; }
        public decimal MontoCuota { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPago { get; set; }
        public LugarPago LugarPago { get; set; }
    }
}
