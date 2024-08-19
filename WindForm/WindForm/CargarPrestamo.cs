using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica2;

namespace WindForm
{
    public partial class CargarPrestamo : Form,IPasarPrestamo
    {
        public CargarPrestamo()
        {
            InitializeComponent();
        }
        private void buttonGuardarPrestamo_Click(object sender, EventArgs e)
        {
            int IdSucursal = int.Parse(textBoxIDSucursalprestamo.Text);
            int IdComercio = int.Parse(textBoxIDComercioAdheridoprestamo.Text);
            tipoDocumento tipoDocumento = ObtenerTipoDocumento();
            int NumeroDocumento = int.Parse(textBoxNumeroDocumentoprestamo.Text);
            decimal MontoCredito = decimal.Parse(textBoxMontoCredito.Text);
            int CantidadCuotas = int.Parse(textBoxCantidadCuotas.Text);

            PasarPrestamo(PasarCliente(tipoDocumento, NumeroDocumento), PasarComercio(IdComercio), PasarSucursal(IdSucursal), MontoCredito, CantidadCuotas);
        }
        public tipoDocumento ObtenerTipoDocumento()
        {
            tipoDocumento tipoDocumento = tipoDocumento.indefinido;

            if (radioButtonDNI.Checked)
            {
                tipoDocumento = tipoDocumento.DNI;
            }

            if (radioButtonLC.Checked)
            {
                tipoDocumento = tipoDocumento.LC;
            }

            if (radioButtonLC.Checked)
            {
                tipoDocumento = tipoDocumento.LE;
            }

            return tipoDocumento;
        }
        public bool PasarPrestamo(Cliente cliente, ComercioAdherido comercioAdherido, Sucursal sucursal, decimal montoCredito, int cantidadCuotas)
        {
            IAdministrarPrestamos administrarPrestamos = this.Owner as IAdministrarPrestamos;
            administrarPrestamos.GuardarPrestamo( cliente, comercioAdherido, sucursal, montoCredito, cantidadCuotas);

            return true;
        }
        public Cliente PasarCliente(tipoDocumento tipoDocumento, int NumeroDocumento)
        {
            IAdministrarPrestamos administrarPrestamos = this.Owner as IAdministrarPrestamos;
            Cliente cliente = administrarPrestamos.BuscarCliente(tipoDocumento, NumeroDocumento);

            return cliente;
        }
        public Sucursal PasarSucursal(int IDSucursal)
        {
            IAdministrarPrestamos administrarPrestamos = this.Owner as IAdministrarPrestamos;
            Sucursal sucursal = administrarPrestamos.BuscarSucursal(IDSucursal);

            return sucursal;
        }
        public ComercioAdherido PasarComercio(int IDComercio)
        {
            IAdministrarPrestamos administrarPrestamos = this.Owner as IAdministrarPrestamos;
            ComercioAdherido comercio = administrarPrestamos.BuscarComercio(IDComercio);

            return comercio;
        }
    }
}
