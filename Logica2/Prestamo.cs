using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica2
{
    public class Prestamo
    {
        public Cliente clienteAsociado { get; set; }
        public int NroPrestamo { get; set; }
        public DateTime Fecha { get; set; }
        public ComercioAdherido  ComercioAdherido { get; set; }
        public Sucursal Sucursal { get; set; }
        public decimal MontoCredito { get; set; }
        public int Tasa { get; set; }
        public int cantCuotas { get; set; }
        public decimal MontoCuota { get; set; }
        public int CantidadCuotasPagadas { get; set; }
        public int CantidadCuotasFaltantes { get; set; }
        public List<Cuota> Cuotas { get; set; }
        public Prestamo(Cliente cliente, int nroPrestamo, ComercioAdherido comercioAdherido, Sucursal sucursal, decimal montoCredito, int cantidadCuotas)
        {
            this.clienteAsociado = cliente;
            this.NroPrestamo = nroPrestamo;
            this.Fecha = DateTime.Now;
            this.ComercioAdherido = comercioAdherido;
            this.Sucursal = sucursal;
            this.MontoCredito = montoCredito + (sucursal.TasaInteres * montoCredito / 100);
            this.Tasa = sucursal.TasaInteres;
            this.cantCuotas = cantidadCuotas;
            try
            {
                this.MontoCuota = MontoCredito / cantidadCuotas;
            }
            catch
            {

            }
            finally
            {
                this.MontoCuota = MontoCredito;
            }
            this.CantidadCuotasPagadas = 0;
            this.CantidadCuotasFaltantes = cantidadCuotas;
            this.Cuotas = ObtenerCuotas(cantidadCuotas);
        }
        public List<Cuota> ObtenerCuotas(int cantCuotas)
        {
            List<Cuota> cuotas = new List<Cuota>();

            for (int i = 0; i < cantCuotas; i++)
            {
                DateTime fechaVencimiento;
                if (i == 0)
                {
                    fechaVencimiento = Fecha.AddDays(60);
                }
                else
                {
                    fechaVencimiento = cuotas.Last().FechaVencimiento.AddMonths(1);
                }

                Cuota nuevaCuota = new Cuota(fechaVencimiento);
                cuotas.Add(nuevaCuota);
            }

            return cuotas;
        }
    }
}
