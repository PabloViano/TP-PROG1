using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica2
{
    public class Cuota
    {
        public Pago PagoAsociado { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Pagada { get; set; }
        public decimal Monto { get; set; }
        public Cuota(DateTime FechaVencimiento, Pago PagoAsociado = null, decimal Monto = 0, bool Pagada = false)
        {
            this.FechaVencimiento = FechaVencimiento;
            this.PagoAsociado = PagoAsociado;
            this.Monto = Monto;
            this.Pagada = Pagada;
        }
    }
}
