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
    public partial class FormCargarComercioAdherido : Form,IPasarComercio
    {
        public FormCargarComercioAdherido()
        {
            InitializeComponent();
        }
        public bool PasarComercio(ComercioAdherido comercio)
        {
            IFormPrincipal formPrincipal = this.Owner as IFormPrincipal;
            formPrincipal.GuardarComercio(comercio);

            return true;
        }
        private void buttonGuardarComercioAdherido_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBoxIDComercioAdherido.Text);
            string Direccion = textBoxDireccionComercioAdherido.Text;
            string RazonSocial = textBoxRazonSocialComercioAdherido.Text;
            int CodigoPostal = int.Parse(textBoxCPComercioAdherido.Text);
            string Ciudad = textBoxCiudadComercioAdherido.Text;

            ComercioAdherido nuevoComercio = new ComercioAdherido(ID,Ciudad,Direccion,CodigoPostal,RazonSocial);
            PasarComercio(nuevoComercio);

            this.Close();
        }
    }
}
