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
    public partial class CargarClientes : Form, IPasarCliente
    {
        public CargarClientes()
        {
            InitializeComponent();
        }

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            string NombreApellido = textBoxNombreApellido.Text;
            int NumeroDocumento = int.Parse(textBoxNumeroDocumento.Text);
            string Domicilio = textBoxDomicilio.Text;
            tipoDocumento tipoDocumento = ObtenerTipoDocumento();
            tipoCliente tipoCliente = ObtenerTipoCliente();
            string Sexo = ObtenerSexo();
            DateTime FechaNacimiento = dateTimePickerFechaNacimiento.Value.Date;
            int CodigoPostal = int.Parse(textBoxCP.Text);
            string Email = textBoxEmail.Text;
            int Celular = int.Parse(textBoxNumeroCelular.Text);
            string Localidad = textBoxLocalidad.Text;
            decimal MontoMaximo = decimal.Parse(textBoxMontoMaximo.Text);

            Cliente nuevoCliente = new Cliente(tipoDocumento, NumeroDocumento, NombreApellido, Email,MontoMaximo, tipoCliente, Celular,FechaNacimiento,Sexo,Domicilio,CodigoPostal,Localidad);
            PasarCliente(nuevoCliente);

            this.Close();
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

            if (radioButtonLE.Checked)
            {
                tipoDocumento = tipoDocumento.LE;
            }

            return tipoDocumento;
        }
        public tipoCliente ObtenerTipoCliente()
        {
            tipoCliente tipoCliente = tipoCliente.indefinido;

            if (radioButtonVIP.Checked)
            {
                tipoCliente = tipoCliente.VIP;
            }

            if (radioButtonRegular.Checked)
            {
                tipoCliente = tipoCliente.Regular;
            }

            return tipoCliente;
        }
        public string ObtenerSexo()
        {
            string Sexo = "";

            if (radioButtonFemenino.Checked)
            {
                Sexo = radioButtonFemenino.Text;
            }

            if (radioButtonMasculino.Checked)
            {
                Sexo = radioButtonMasculino.Text;
            }

            return Sexo;
        }
        public bool PasarCliente(Cliente cliente)
        {
            IAdministrarClientes administrarClientes = this.Owner as IAdministrarClientes;
            administrarClientes.GuardarCliente(cliente);

            return true;
        }
    }
}
