using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica2
{
    public class Cliente
    {
        public tipoDocumento TipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public string NombreApellido { get; set; }
        public string Email { get; set; }
        public int Celular { get; set; }
        public DateTime FechaNac { get; set; }
        public string Sexo { get; set; }
        public string Domicilio { get; set; }
        public int CP { get; set; }
        public string Localidad { get; set; }
        public tipoCliente TipoCliente { get; set; }
        public decimal MontoMaximo { get; set; }

        public Cliente(tipoDocumento TipoDocumento, int NumeroDocumento, string NombreApellido, string Email, decimal MontoMax, tipoCliente TipoCliente, int Celular = 0, DateTime FechaNac = default(DateTime), string Sexo = "", string Domicilio = "", int CP = 0, string Localidad = "")
        {
            this.TipoDocumento = TipoDocumento;
            this.NumeroDocumento = NumeroDocumento;
            this.NombreApellido = NombreApellido;
            this.Email = Email;
            this.MontoMaximo = MontoMax;
            this.TipoCliente = TipoCliente;
            this.Celular = Celular;
            this.FechaNac = FechaNac;
            this.Sexo = Sexo;
            this.Domicilio = Domicilio;
            this.CP = CP;
            this.Localidad = Localidad;
        }

    }
}
