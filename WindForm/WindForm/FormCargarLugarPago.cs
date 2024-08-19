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
    public partial class FormCargarLugarPago : Form,IPasarLugar
    {
        public FormCargarLugarPago()
        {
            InitializeComponent();
        }
        public bool PasarLugar(LugarPago lugar)
        {
            IFormPrincipal formPrincipal = this.Owner as IFormPrincipal;
            formPrincipal.GuardarLugar(lugar);

            return true;
        }
        private void buttonGuardarLugarPago_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBoxIDLugarPago.Text);
            string Direccion = textBoxDireccionLugarPago.Text;
            string RazonSocial = textBoxRazonSocialLugarPago.Text;
            int CodigoPostal = int.Parse(textBoxCPLugarPago.Text);
            string Ciudad = textBoxCiudadLugarPago.Text;

            LugarPago lugarPago = new LugarPago(ID, Ciudad, Direccion, CodigoPostal, RazonSocial, EncontrarEsSucursal());
            PasarLugar(lugarPago);

            this.Close();
        }
        public bool EncontrarEsSucursal()
        {
            if (checkBoxEsSucursal.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
